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

using var client = new HttpClient();
var api = new AnthropicApi(apiKey, client);
var response = await api.CompleteAsync(new CreateCompletionRequest
{
    Model = ModelIds.ClaudeInstant,
    Prompt = "Once upon a time".AsPrompt(),
    Max_tokens_to_sample = 250,
});
Console.WriteLine(response.Completion);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Anthropic/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Anthropic/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  