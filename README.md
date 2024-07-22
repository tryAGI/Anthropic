# Anthropic

[![Nuget package](https://img.shields.io/nuget/vpre/Anthropic)](https://www.nuget.org/packages/Anthropic/)
[![dotnet](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Anthropic)](https://github.com/tryAGI/Anthropic/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

Generated C# SDK based on [Anthropic OpenAPI specification](https://raw.githubusercontent.com/davidmigloz/langchain_dart/main/packages/anthropic_sdk_dart/oas/anthropic_openapi_curated.yaml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)  
Includes [tokenizer](https://github.com/tryAGI/Tiktoken) and some helper methods.

### Usage
```csharp
using Anthropic;

using var api = new AnthropicApi();
api.AuthorizeUsingApiKey(apiKey);
api.SetHeaders();

var response = await api.CreateMessageAsync(
    model: CreateMessageRequestModel.Claude3Haiku20240307,
    messages: [
        "What's the weather like today?",
        "Sure! Could you please provide me with your location?".AsAssistantMessage(),
        "Dubai, UAE",
    ],
    maxTokens: 250);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Anthropic/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Anthropic/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  