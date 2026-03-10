namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FiveRandomWords()
    {
        using var client = GetAuthenticatedClient();
        
        var response = await client.MessagesPostAsync(
            model: DefaultModel,
            messages: ["Generate 5 random words."],
            maxTokens: 300,
            temperature: 0);
        //response.Model.Object.Should().Be(ModelVariant2.Claude37SonnetLatest);
        response.Content.Should().NotBeNullOrEmpty();
        response.Content!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
        response.AsSimpleText().Should().NotBeNullOrEmpty();
        
        Console.WriteLine(response.AsSimpleText());
    }
}
