namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CompleteHistory()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.MessagesPostAsync(
            model: "claude-sonnet-4-6",
            messages: [
                "What's the weather like today?",
                "Sure! Could you please provide me with your location?".AsAssistantMessage(),
                "Dubai, UAE",
            ],
            maxTokens: 300,
            metadata: null,
            stopSequences: null,
            system: null,
            temperature: 0,
            toolChoice: null,
            tools: null,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.ToString().Should().Contain("claude-sonnet");
        response.Content.Should().NotBeNullOrEmpty();
        response.Content.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
