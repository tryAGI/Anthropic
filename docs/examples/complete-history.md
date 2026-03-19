# Complete History



This example assumes `using Anthropic;` is in scope and `apiKey` contains your Anthropic API key.

```csharp
using var client = new AnthropicClient(apiKey);

var response = await client.MessagesPostAsync(
    model: DefaultModel,
    messages: [
        "What's the weather like today?",
        "Sure! Could you please provide me with your location?".AsAssistantMessage(),
        "Dubai, UAE",
    ],
    maxTokens: 300,
    temperature: 0);

Console.WriteLine(response.AsSimpleText());
```