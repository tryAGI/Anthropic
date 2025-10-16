namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CompleteHistory()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.MessagesPostAsync(
            model: ModelVariant2.Claude37SonnetLatest,
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
        response.Model.Value2.Should().Be(ModelVariant2.Claude37SonnetLatest);
        response.Content.Should().NotBeNullOrEmpty();
        response.Content.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
