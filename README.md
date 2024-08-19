# Anthropic

[![Nuget package](https://img.shields.io/nuget/vpre/Anthropic)](https://www.nuget.org/packages/Anthropic/)
[![dotnet](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Anthropic/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Anthropic)](https://github.com/tryAGI/Anthropic/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [OpenAPI specification](https://raw.githubusercontent.com/davidmigloz/langchain_dart/main/packages/anthropic_sdk_dart/oas/anthropic_openapi_curated.yaml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Automatic releases of new preview versions if there was an update to the OpenAPI specification
- Source generator to define tools natively through C# interfaces
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

## Usage
```csharp
using Anthropic;

using var api = new AnthropicApi(apiKey);

var response = await api.CreateMessageAsync(
    model: CreateMessageRequestModel.Claude35Sonnet20240620,
    messages: [
        "What's the weather like today?",
        "Sure! Could you please provide me with your location?".AsAssistantMessage(),
        "Dubai, UAE",
    ],
    maxTokens: 250);
```

### Tools
```csharp
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

[AnthropicTools]
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

using var api = new AnthropicApi(apiKey);

var service = new WeatherService();
var tools = service.AsTools();

List<Message> messages = ["What is the current temperature in Dubai, UAE in Celsius?"];

var response = await api.CreateMessageAsync(
    model: CreateMessageRequestModel.Claude35Sonnet20240620,
    messages: messages,
    maxTokens: 300,
    system: "You are a helpful weather assistant.",
    toolChoice: new ToolChoice
    {
        Type = ToolChoiceType.Auto,
    },
    tools: tools);

messages.Add(response.AsRequestMessage());

foreach (var toolUse in response.Content.Value2!
     .Where(x => x.IsToolUse)
     .Select(x => x.ToolUse))
{
    var json = await service.CallAsync(
        functionName: toolUse!.Name,
        argumentsAsJson: toolUse.Input.AsJson());
    messages.Add(json.AsToolCall(toolUse));
}

response = await api.CreateMessageAsync(
    model: CreateMessageRequestModel.Claude35Sonnet20240620,
    messages: messages,
    maxTokens: 300,
    system: "You are a helpful weather assistant.",
    toolChoice: new ToolChoice
    {
        Type = ToolChoiceType.Auto,
    },
    tools: tools);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Anthropic/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Anthropic/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  