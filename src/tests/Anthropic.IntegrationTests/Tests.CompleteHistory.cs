namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CompleteHistory()
    {
        using var api = GetAuthorizedApi();
        
        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude35Sonnet20240620,
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
        response.Model.Should().Be(CreateMessageRequestModel.Claude35Sonnet20240620.ToValueString());
        response.Content.Value2.Should().NotBeNullOrEmpty();
        response.Content.Value2!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
    }
}
