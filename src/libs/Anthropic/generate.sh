#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: bundled by anthropics/anthropic-sdk-typescript for its mock server.

use_pinned_spec=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec)
      use_pinned_spec=true
      ;;
    *)
      echo "Unknown argument: $arg" >&2
      exit 1
      ;;
  esac
done
if [[ "${TRYAGI_PINNED_SPEC:-0}" == "1" ]]; then
  use_pinned_spec=true
fi
if [[ -n "${AUTOSDK_EXECUTABLE:-}" ]]; then
  autosdk() { "$AUTOSDK_EXECUTABLE" "$@"; }
else
  install_autosdk_cli
fi
rm -rf Generated
if [[ "$use_pinned_spec" == false ]]; then
  compressed_spec="$(mktemp)"
  trap 'rm -f "$compressed_spec"' EXIT
  fetch_spec -o "$compressed_spec" https://raw.githubusercontent.com/anthropics/anthropic-sdk-typescript/refs/heads/main/scripts/mock-spec.json.gz
  gzip -dc "$compressed_spec" > openapi.yaml
elif [[ ! -f openapi.yaml ]]; then
  echo "error: --pinned-spec requested but openapi.yaml does not exist." >&2
  exit 1
fi
if ! command -v yq >/dev/null 2>&1 || ! command -v jq >/dev/null 2>&1; then
  echo "jq and yq are required to patch the downloaded OpenAPI spec." >&2
  exit 1
fi

# The bundled spec keys every beta endpoint by appending `?beta=true` to the path, because OpenAPI
# cannot declare two operations on one path and method. x-autosdk-path tells AutoSDK the real
# request path so the disambiguator is not sent to the API as a query parameter.
tmp_openapi="$(mktemp)"
yq -o=json '.' openapi.yaml | jq '
  .paths |= (
    to_entries
    | map(
        if (.key | test("\\?")) then
          (.key | split("?")[0]) as $real
          | .value |= with_entries(
              if (.key | test("^(get|put|post|delete|options|head|patch|trace)$"))
              then .value += { "x-autosdk-path": $real }
              else . end)
        else . end)
    | from_entries
  ) |
  # The API omits `caller` on response tool-use blocks, while the spec marks it required in 52
  # schemas, so any response that uses a server tool fails to deserialize. It is a response-only
  # field: making it optional cannot affect requests.
  .components.schemas |= with_entries(
    if (.value | type) == "object" and (.value.required | type) == "array"
    then .value.required |= map(select(. != "caller"))
    else . end
  ) |
  # The bundled spec describes every streaming response as plain JSON, which is why AutoSDK could
  # not generate a stream for them and this SDK hand-wrote the transport. Declaring the
  # `text/event-stream` variant - the same shape the OpenAI spec uses - makes the generator emit
  # the `*AsStream` methods, so the hand-written path can go.
  .paths["/v1/messages"].post.responses["200"].content["text/event-stream"] =
    { "schema": { "$ref": "#/components/schemas/MessageStreamEvent" } } |
  .paths["/v1/messages?beta=true"].post.responses["200"].content["text/event-stream"] =
    { "schema": { "$ref": "#/components/schemas/BetaMessageStreamEvent" } } |
  .paths["/v1/sessions/{session_id}/events/stream?beta=true"].get.responses["200"].content["text/event-stream"] =
    { "schema": { "$ref": "#/components/schemas/BetaManagedAgentsStreamSessionEvents" } } |
  .paths["/v1/sessions/{session_id}/threads/{thread_id}/stream?beta=true"].get.responses["200"].content["text/event-stream"] =
    { "schema": { "$ref": "#/components/schemas/BetaManagedAgentsStreamSessionThreadEvents" } } |
  .components.schemas.Ping = {
    "type": "object",
    "properties": {
      "type": {
        "type": "string",
        "enum": ["ping"],
        "default": "ping"
      }
    },
    "required": ["type"]
  } |
  .components.schemas.MessageStreamEvent.oneOf |= (map(select(."$ref" != "#/components/schemas/Ping")) + [{"$ref": "#/components/schemas/Ping"}]) |
  .components.schemas.MessageStreamEvent.discriminator.mapping.ping = "#/components/schemas/Ping" |
  .components.schemas.BetaMessageStreamEvent.oneOf |= (map(select(."$ref" != "#/components/schemas/Ping")) + [{"$ref": "#/components/schemas/Ping"}]) |
  .components.schemas.BetaMessageStreamEvent.discriminator.mapping.ping = "#/components/schemas/Ping"
' > "$tmp_openapi" && mv "$tmp_openapi" openapi.yaml

autosdk generate openapi.yaml \
  --shared-json-metadata \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --generate-multipart-upload-helpers \
  --generate-webhook-verifier \
  --webhook-verifier-class-name AnthropicWebhookVerifier \
  --openapi-override '#/components/schemas/Tool/properties/input_schema=object' \
  --openapi-override '#/components/schemas/BetaTool/properties/input_schema=object'
