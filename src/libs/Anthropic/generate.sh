dotnet tool install --global openapigenerator.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/davidmigloz/langchain_dart/main/packages/anthropic_sdk_dart/oas/anthropic_openapi_curated.yaml
#dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
#if [ $? -ne 0 ]; then
#  echo "Failed, exiting..."
#  exit 1
#fi
oag generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations