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

# OpenAPI spec: resolved from anthropics/anthropic-sdk-typescript/.stats.yml (Stainless-hosted)

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
install_autosdk_cli
rm -rf Generated
if [[ "$use_pinned_spec" == false ]]; then
  fetch_spec --fail --silent --show-error -L -o .stats.yml https://raw.githubusercontent.com/anthropics/anthropic-sdk-typescript/refs/heads/main/.stats.yml
  openapi_spec_url=$(sed -n 's/^openapi_spec_url: //p' .stats.yml)
  echo "OpenAPI spec URL: $openapi_spec_url"
  rm .stats.yml
  fetch_spec --fail --silent --show-error -L -o openapi.yaml $openapi_spec_url
elif [[ ! -f openapi.yaml ]]; then
  echo "error: --pinned-spec requested but openapi.yaml does not exist." >&2
  exit 1
fi
if ! command -v yq >/dev/null 2>&1 || ! command -v jq >/dev/null 2>&1; then
  echo "jq and yq are required to patch the downloaded OpenAPI spec." >&2
  exit 1
fi

tmp_openapi="$(mktemp)"
yq -o=json '.' openapi.yaml | jq '
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
  .components.schemas.MessageStreamEvent.oneOf += [{"$ref": "#/components/schemas/Ping"}] |
  .components.schemas.MessageStreamEvent.discriminator.mapping.ping = "#/components/schemas/Ping"
' > "$tmp_openapi" && mv "$tmp_openapi" openapi.yaml

autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --generate-multipart-upload-helpers \
  --openapi-override '#/components/schemas/Tool/properties/input_schema=object' \
  --openapi-override '#/components/schemas/BetaTool/properties/input_schema=object'
