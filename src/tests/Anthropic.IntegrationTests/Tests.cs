using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

[TestClass]
public partial class Tests
{
    private const string DefaultModel = "claude-sonnet-4-5";

    private static AnthropicClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") is { Length: > 0 } anthropicKeyValue ? anthropicKeyValue :
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        return new AnthropicClient(apiKey) { ReadResponseAsString = true };
    }

    private static IChatClient GetAuthenticatedChatClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") is { Length: > 0 } anthropicKeyValue ? anthropicKeyValue :
            throw new AssertInconclusiveException("ANTHROPIC_API_KEY environment variable is not found.");

        return new AnthropicClient(apiKey) { ReadResponseAsString = true };
    }
}
