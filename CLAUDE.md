# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Anthropic](https://anthropic.com/) Claude API, auto-generated from the official Anthropic OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as NuGet package `tryAGI.Anthropic`. This is not an official Anthropic SDK.

Features beyond basic API access include a source generator for defining tools natively through C# interfaces, streaming support, and Microsoft.Extensions.AI integration.

## Build Commands

```bash
# Build the solution
dotnet build Anthropic.slnx

# Build for release (also produces NuGet package)
dotnet build Anthropic.slnx -c Release

# Run integration tests (requires ANTHROPIC_API_KEY or API_KEY env var)
dotnet test src/tests/Anthropic.IntegrationTests/Anthropic.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Anthropic && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `src/libs/Anthropic/Generated/` is **entirely auto-generated** -- do not manually edit files there.

1. `src/libs/Anthropic/openapi.yaml` -- the Anthropic OpenAPI spec (fetched from the official TypeScript SDK's `.stats.yml`)
3. `src/libs/Anthropic/generate.sh` -- orchestrates: download spec URL from `.stats.yml`, fetch spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Anthropic/` | Main SDK library (`AnthropicClient`) |
| `src/tests/Anthropic.IntegrationTests/` | Integration tests against real Anthropic API |

### Hand-Written Extensions

This SDK has significant hand-written code alongside the generated code:

| File | Purpose |
|------|---------|
| `AnthropicClient.AdditionalConstructors.cs` | Extra constructor overloads |
| `AnthropicClient.Streaming.cs` | Server-sent events streaming support |
| `InputMessage.cs` | Input message helper type |
| `Message.cs` | Message extension methods |
| `JsonSerializerContextTypes.AdditionalTypes.cs` | Additional types for System.Text.Json source gen |
| `Extensions/AnthropicClient.ChatClient.cs` | Microsoft.Extensions.AI `IChatClient` implementation |
| `Extensions/StringExtensions.cs` | String helper utilities |
| `Metadata/` | Chat model metadata for AI abstractions (`ChatModelMetadata.cs`, `Metadata.Chat.cs`, `Metadata.cs`) |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions
- **Dependencies:** CSharpToJsonSchema (tool definitions), Microsoft.Extensions.AI.Abstractions, System.Net.ServerSentEvents

### Key Conventions

- The client class is named `AnthropicClient`
- The namespace is `Anthropic`
- Tools are defined via C# interfaces decorated with `[GenerateJsonSchema]` from the CSharpToJsonSchema package
- Supports Microsoft.Extensions.AI `IChatClient` abstraction
- Streaming uses `System.Net.ServerSentEvents`

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
