namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FiveRandomWords()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.Messages.MessagesPostAsync(
            model: ModelEnum.Claude35Sonnet20240620,
            messages: ["Generate 5 random words."],
            maxTokens: 250,
            metadata: null,
            stopSequences: null,
            system: null,
            temperature: 0,
            toolChoice: null,
            tools: null,
            topK: 0,
            topP: 0,
            stream: false);
        response.Model.Object.Should().Be(ModelEnum.Claude35Sonnet20240620);
        response.Content.Should().NotBeNullOrEmpty();
        response.Content!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(MessageStopReason.EndTurn);
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
