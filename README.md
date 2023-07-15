# Anthropic

[![Nuget package](https://img.shields.io/nuget/vpre/Anthropic)](https://www.nuget.org/packages/Anthropic/)
[![dotnet](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Anthropic)](https://github.com/tryAGI/Anthropic/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

Generated C# SDK based on official Anthropic OpenAPI specification using NSwag.  
Includes [tokenizer](https://github.com/tryAGI/Tiktoken) and some helper methods.

### Usage
```csharp
using Anthropic;

using var httpClient = new HttpClient();
var api = new AnthropicApi(apiKey, httpClient);
var result = await api.CreateCompletionAsync(new CreateChatCompletionRequest
{
    Messages = new List<ChatCompletionRequestMessage>
    {
        "You are a helpful weather assistant.".AsSystemMessage(),
        "What's the weather like today?".AsUserMessage(),
    },
    Model = "claude2",
});
// ...
var resultMessage = result.GetFirstChoiceMessage();
var functionArgumentsJson = resultMessage.Function_call?.Arguments ?? string.Empty;
var json = await service.CallGetCurrentWeatherAsync(functionArgumentsJson);
// or just get arguments
var args = service.AsGetCurrentWeatherAsyncArgs(functionArgumentsJson);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Anthropic/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Anthropic/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  