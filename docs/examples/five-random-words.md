# Five Random Words



This example assumes `using Anthropic;` is in scope and `apiKey` contains your Anthropic API key.

```csharp
using var client = new AnthropicClient(apiKey);

var response = await client.MessagesPostAsync(
    model: DefaultModel,
    messages: ["Generate 5 random words."],
    maxTokens: 300,
    temperature: 0);

Console.WriteLine(response.AsSimpleText());
```