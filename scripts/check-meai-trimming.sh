#!/usr/bin/env bash
set -euo pipefail
runtime_id=${1:-linux-x64}
output=${2:-"$PWD/artifacts/meai-trimming"}
scenario=${3:-Chat}
native_aot=${4:-false}
case "$scenario" in Chat|TypedChat|Tools|Stream|TypedStream|CustomTools|CustomStream|ErrorString|ErrorStream|StreamTools|CustomStreamTools|StreamCancellation|StreamMalformed) ;; *) echo "Unknown scenario: $scenario" >&2; exit 2 ;; esac
case "$native_aot" in true|false) ;; *) echo "NativeAOT must be true or false" >&2; exit 2 ;; esac
mkdir -p "$output"
output=$(cd "$output" && pwd)
version=${SDK_PACKAGE_VERSION:-"0.0.0-meai-$(date +%s)-$RANDOM"}
feed=${SDK_PACKAGE_FEED:-"$output/feed"}
if [[ -z "${SDK_PACKAGE_VERSION:-}" ]]; then
  dotnet pack src/libs/Anthropic/Anthropic.csproj -c Release \
    --artifacts-path "$output/sdk-artifacts" -o "$feed" \
    -p:GeneratePackageOnBuild=false -p:PackageVersion="$version" -p:MinVerVersionOverride="$version" \
    -maxcpucount:1 -nodeReuse:false -p:UseSharedCompilation=false
fi
dotnet publish src/tests/Anthropic.MeaiTrimmingCheck/Anthropic.MeaiTrimmingCheck.csproj \
  -c Release -r "$runtime_id" --self-contained true \
  --source "$feed" --source https://api.nuget.org/v3/index.json \
  --artifacts-path "$output/consumer-artifacts" -o "$output/publish" \
  -p:SdkPackageVersion="$version" -p:ProbeScenario="$scenario" -p:PublishAot="$native_aot" \
  -maxcpucount:1 -nodeReuse:false -p:UseSharedCompilation=false \
  2>&1 | tee "$output/publish.log"
if grep -Ei 'warning IL[0-9]+' "$output/publish.log"; then
  echo "Trimming/NativeAOT warnings found." >&2
  exit 1
fi
"$output/publish/Anthropic.MeaiTrimmingCheck"
if [[ "$native_aot" == false ]]; then
  dotnet run --project src/tests/Anthropic.RetentionInspector/Anthropic.RetentionInspector.csproj \
    -c Release --artifacts-path "$output/inspector-artifacts" \
    -- "$output/publish/Anthropic.dll" | tee "$output/retention.json"
fi
