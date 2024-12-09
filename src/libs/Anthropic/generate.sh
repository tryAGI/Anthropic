dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o .stats.yml https://raw.githubusercontent.com/anthropics/anthropic-sdk-typescript/refs/heads/main/.stats.yml
openapi_spec_url=$(sed -n 's/^openapi_spec_url: //p' .stats.yml)
echo "OpenAPI spec URL: $openapi_spec_url"
rm .stats.yml
curl -o openapi.yaml $openapi_spec_url
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations