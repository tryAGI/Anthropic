namespace Anthropic.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AnthropicApi GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") ??
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        return new AnthropicApi(apiKey);
    }
}
