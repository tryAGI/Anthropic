# Chat Client Five Random Lines



This example assumes `using Anthropic;` is in scope and `apiKey` contains your Anthropic API key.

```csharp
using var client = GetAuthenticatedChatClient();

var response = await client.GetResponseAsync(
    messages: [new ChatMessage(ChatRole.User, "Generate 5 random words.")],
    new ChatOptions
    {
        ModelId = DefaultModel,
        ResponseFormat = ChatResponseFormatForType<StringArraySchema>(),
        Tools = new List<AITool>(),
    });

Console.WriteLine(response.ToString());
```