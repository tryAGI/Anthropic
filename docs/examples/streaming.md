# Streaming



This example assumes `using Anthropic;` is in scope and `apiKey` contains your Anthropic API key.

```csharp
using var client = new AnthropicClient(apiKey);

var enumerable = client.CreateMessageAsStreamAsync(new CreateMessageParams
{
    Model = DefaultModel,
    Messages = ["Once upon a time"],
    MaxTokens = 250,
});

var deltas = new List<string>();
await foreach (var response in enumerable)
{
    Console.Write(response.ContentBlockDelta?.Delta.TextDelta?.Text);

    deltas.Add(response.ContentBlockDelta?.Delta.TextDelta?.Text ?? string.Empty);
}
```