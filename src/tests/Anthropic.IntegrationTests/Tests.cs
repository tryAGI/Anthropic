namespace Anthropic.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task Complete()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") ??
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        using var api = new AnthropicApi();
        api.AuthorizeUsingApiKey(apiKey);
        api.SetHeaders();
        
        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude3Haiku20240307,
            messages: ["Once upon a time"],
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
        response.Model.Should().Be(CreateMessageRequestModel.Claude3Haiku20240307.ToValueString());
        response.Content.Value2.Should().NotBeNullOrEmpty();
        response.Content.Value2!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
    }
    
    [TestMethod]
    public async Task CompleteHistory()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") ??
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        using var api = new AnthropicApi();
        api.AuthorizeUsingApiKey(apiKey);
        api.SetHeaders();
        
        var response = await api.CreateMessageAsync(
            model: CreateMessageRequestModel.Claude3Haiku20240307,
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
        response.Model.Should().Be(CreateMessageRequestModel.Claude3Haiku20240307.ToValueString());
        response.Content.Value2.Should().NotBeNullOrEmpty();
        response.Content.Value2!.First().Text?.Text.Should().NotBeNullOrEmpty();
        response.StopReason.Should().Be(StopReason.EndTurn);
    }
}
