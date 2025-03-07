# Anthropic

[![Nuget package](https://img.shields.io/nuget/vpre/Anthropic)](https://www.nuget.org/packages/Anthropic/)
[![dotnet](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Anthropic)](https://github.com/tryAGI/Anthropic/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAPI specification](https://raw.githubusercontent.com/anthropics/anthropic-sdk-typescript/refs/heads/main/.stats.yml) using [AutoSDK](https://github.com/HavenDV/OpenApiGenerator)
- Automatic releases of new preview versions if there was an update to the OpenAPI specification
- Source generator to define tools natively through C# interfaces
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Supporting [Microsoft.Extensions.AI](https://devblogs.microsoft.com/dotnet/introducing-microsoft-extensions-ai-preview/)
- Supports all endpoints of the API, including batch requests, count tokens, and prompt caching.

## Usage
```csharp
using Anthropic;

using var client = new AnthropicClient(apiKey);

var messageParams = new CreateMessageParams()
{   
    Model = new Model(ModelVariant6.Claude35SonnetLatest),
    Messages = [
        new InputMessage(InputMessageRole.User, "What's the weather like today?"),
        new InputMessage(InputMessageRole.Assistant, "Sure! Could you please provide me with your location?"),
        new InputMessage(InputMessageRole.User, "Dubai, UAE")
    ],
    MaxTokens = 250
};
var response = await client.Messages.MessagesPostAsync(messageParams);
```

### Tools
```csharp
using CSharpToJsonSchema;

public enum Unit
{
    Celsius,
    Fahrenheit,
}

public class Weather
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public Unit Unit { get; set; }
    public string Description { get; set; } = string.Empty;
}

[GenerateJsonSchema]
public interface IWeatherFunctions
{
    [Description("Get the current weather in a given location")]
    public Weather GetCurrentWeather(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit = Unit.Celsius);
    
    [Description("Get the current weather in a given location")]
    public Task<Weather> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit = Unit.Celsius,
        CancellationToken cancellationToken = default);
}

public class WeatherService : IWeatherFunctions
{
    public Weather GetCurrentWeather(string location, Unit unit = Unit.Celsius)
    {
        return new Weather
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        };
    }
    
    public Task<Weather> GetCurrentWeatherAsync(string location, Unit unit = Unit.Celsius, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new Weather
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        });
    }
}
```
```csharp
using Anthropic;

using var client = new AnthropicClient(apiKey);

var service = new WeatherService();
var tools = service.AsTools();

var messageParams = new CreateMessageParams()
{   
    Model = new Model(ModelVariant6.Claude35SonnetLatest),
    Messages = [new InputMessage(InputMessageRole.User, "What is the current temperature in Dubai, UAE in Celsius?")],
    MaxTokens = 4096,
    System = "You are a helpful weather assistant.",
    ToolChoice = new ToolChoice(new ToolChoiceAuto()),
    Tools = tools
};
var response = await client.Messages.MessagesPostAsync(messageParams);

messageParams.Messages.Add(response.AsInputMessage());

foreach (var toolUse in response.Content.Value2!
     .Where(x => x.IsToolUse)
     .Select(x => x.ToolUse))
{
    var json = await service.CallAsync(
        functionName: toolUse!.Name,
        argumentsAsJson: toolUse.Input.AsJson());
    messageParams.Messages.Add(json.AsToolCall(toolUse));
}

response = await client.Messages.MessagesPostAsync(messageParams);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Anthropic/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Anthropic/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).