namespace Anthropic.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AnthropicClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") ??
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") ??
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        return new AnthropicClient(apiKey);
    }
}
