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

        using var client = new HttpClient();
        var api = new AnthropicApi(apiKey, client);
        var response = await api.CompleteAsync(new CreateCompletionRequest
        {
            Model = ModelIds.ClaudeInstant,
            Prompt = "Once upon a time".AsPrompt(),
            Max_tokens_to_sample = 250,
        });
        response.Model.Should().Be(ModelIds.ClaudeInstant);
        response.Completion.Should().NotBeNullOrEmpty();
        response.Stop_reason.Should().Be(CreateCompletionResponseStop_reason.Stop_sequence);
    }
    
    [TestMethod]
    public async Task CompleteHistory()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") ??
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        using var client = new HttpClient();
        var api = new AnthropicApi(apiKey, client);
        var response = await api.CompleteAsync(new CreateCompletionRequest
        {
            Model = ModelIds.ClaudeInstant,
            Prompt = new []
            {
                "What's the weather like today?".AsHumanMessage(),
                "Sure! Could you please provide me with your location?".AsAssistantMessage(),
                "Dubai, UAE".AsHumanMessage(),
            }.AsPrompt(),
            Max_tokens_to_sample = 300,
        });
        response.Model.Should().Be(ModelIds.ClaudeInstant);
        response.Completion.Should().NotBeNullOrEmpty();
        response.Stop_reason.Should().Be(CreateCompletionResponseStop_reason.Stop_sequence);
    }
}
