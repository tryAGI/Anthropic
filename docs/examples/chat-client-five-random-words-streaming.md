# Chat Client Five Random Words Streaming



This example assumes `using Anthropic;` is in scope and `apiKey` contains your Anthropic API key.

```csharp
using var client = GetAuthenticatedChatClient();

var enumerable = client.GetStreamingResponseAsync(
    messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
    new ChatOptions
    {
        ModelId = DefaultModel,
    });

var deltas = new List<string>();
await foreach (var response in enumerable)
{
    Console.Write(response.ToString());

    deltas.Add(response.ToString());
}
```