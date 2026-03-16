dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o .stats.yml https://raw.githubusercontent.com/anthropics/anthropic-sdk-typescript/refs/heads/main/.stats.yml
openapi_spec_url=$(sed -n 's/^openapi_spec_url: //p' .stats.yml)
echo "OpenAPI spec URL: $openapi_spec_url"
rm .stats.yml
curl -o openapi.yaml $openapi_spec_url
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
  --openapi-override '#/components/schemas/Tool/properties/input_schema=object' \
  --openapi-override '#/components/schemas/BetaTool/properties/input_schema=object'
