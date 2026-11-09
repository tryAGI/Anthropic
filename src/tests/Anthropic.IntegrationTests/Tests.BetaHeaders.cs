using System.Net;
using System.Net.Http;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    /// <summary>
    /// Every beta capability — fast mode, task budgets, compaction, context editing — is gated on
    /// the `anthropic-beta` header, so a wrong wire value silently disables the feature.
    /// </summary>
    [TestMethod]
    public async Task BetaHeaderIsSentAsCommaSeparatedWireValues()
    {
        var handler = new CapturingHandler(
            """
            {
              "id": "msg_01",
              "type": "message",
              "role": "assistant",
              "model": "claude-sonnet-5-5",
              "content": [{ "type": "text", "text": "ok" }],
              "stop_reason": "end_turn",
              "usage": { "input_tokens": 1, "output_tokens": 1 }
            }
            """);
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://api.anthropic.com"),
        };
        using var client = new AnthropicClient(httpClient, authorizations: null, options: null);

        _ = await client.BetaMessagesPostAsync(
            new BetaCreateMessageParams
            {
                Model = "claude-sonnet-5-5",
                MaxTokens = 16,
                Messages = [],
            },
            anthropicBeta:
            [
                new AnthropicBeta(AnthropicBetaEnum.FastMode20260201),
                new AnthropicBeta(AnthropicBetaEnum.TaskBudgets20260313),
            ]);

        handler.Request.Should().NotBeNull();
        handler.Request!.Headers.TryGetValues("anthropic-beta", out var values).Should().BeTrue();
        string.Join(",", values!).Should().Be("fast-mode-2026-02-01,task-budgets-2026-03-13");
    }

    private sealed class CapturingHandler(string responseJson) : HttpMessageHandler
    {
        public HttpRequestMessage? Request { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Request = request;

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(responseJson, System.Text.Encoding.UTF8, "application/json"),
            });
        }
    }
}
