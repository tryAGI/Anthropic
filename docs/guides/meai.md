# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The `tryAGI.Anthropic` SDK implements the `Microsoft.Extensions.AI` `IChatClient` interface, enabling you to use Anthropic Claude models through a standardized .NET AI abstraction.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `IChatClient` | Full (text, streaming, tool calling, images, PDFs, thinking) |

## IChatClient

### Installation

```bash
dotnet add package tryAGI.Anthropic
```

### Basic Usage

```csharp
using Anthropic;
using Microsoft.Extensions.AI;

using var client = new AnthropicClient(apiKey);
IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "What is the capital of France?",
    new ChatOptions
    {
        ModelId = "claude-sonnet-4-20250514",
    });

Console.WriteLine(response.Text);
```

### Streaming

```csharp
IChatClient chatClient = client;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    "Write a short poem about coding.",
    new ChatOptions
    {
        ModelId = "claude-sonnet-4-20250514",
    }))
{
    Console.Write(update.Text);
}
```

### Tool Calling

Define tools using CSharpToJsonSchema and pass them via `ChatOptions`:

```csharp
using CSharpToJsonSchema;

[GenerateJsonSchema]
public interface IWeatherTools
{
    [Description("Gets the current weather for a location.")]
    string GetWeather(
        [Description("The city name")] string city);
}

IChatClient chatClient = client;
var service = new WeatherToolsService();

var response = await chatClient.GetResponseAsync(
    "What's the weather in Paris?",
    new ChatOptions
    {
        ModelId = "claude-sonnet-4-20250514",
        Tools = service.AsTools().AsAITools(),
    });
```

### Image Input

```csharp
IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new ImageContent(imageBytes, "image/png"),
            new TextContent("Describe this image."),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "claude-sonnet-4-20250514",
    });
```

### Extended Thinking

Enable extended thinking through `AdditionalProperties`:

```csharp
IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "Solve this step by step: What is 147 * 283?",
    new ChatOptions
    {
        ModelId = "claude-sonnet-4-20250514",
        AdditionalProperties = new AdditionalPropertiesDictionary
        {
            ["thinking"] = true,
        },
    });
```

### Token Usage

Token usage information is available on the response:

```csharp
var response = await chatClient.GetResponseAsync("Hello!");

Console.WriteLine($"Input tokens: {response.Usage?.InputTokenCount}");
Console.WriteLine($"Output tokens: {response.Usage?.OutputTokenCount}");
```
