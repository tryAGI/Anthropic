using System.Net;
using System.Net.Http;

namespace Anthropic.IntegrationTests;

/// <summary>
/// The streaming transport is generated rather than hand-written, which means the request it sends
/// is assembled from the specification. Two things in that assembly are patched in by
/// <c>generate.sh</c> and would fail silently if a regeneration dropped them: the real request path
/// (the spec keys the beta operations as <c>/v1/messages?beta=true</c>, which is not a query
/// parameter but the key of a separate path item) and the <c>anthropic-beta</c> header, which a
/// generator that calls <c>ToString()</c> on the list turns into
/// <c>System.Collections.Generic.List`1[...]</c>.
/// </summary>
public partial class Tests
{
    [TestMethod]
    public async Task BetaStreamingSendsTheRealPathAndHeaders()
    {
        var handler = new SseHandler("data: {\"type\":\"ping\"}\n\n");
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://api.anthropic.com"),
        };
        using var client = new AnthropicClient(httpClient, authorizations: null, options: null);

        var events = new List<BetaMessageStreamEvent>();
        await foreach (var @event in client.CreateBetaMessageAsStreamAsync(
            new BetaCreateMessageParams
            {
                Model = "claude-haiku-5-5",
                MaxTokens = 16,
                Messages = ["hi"],
            },
            anthropicBeta: [new AnthropicBeta(AnthropicBetaEnum.FastMode20260201)]))
        {
            events.Add(@event);
        }

        handler.Request.Should().NotBeNull();
        // Not `/v1/messages?beta=true`: that is how the spec keys the operation, not what the API
        // accepts. This is what `x-autosdk-path` exists for.
        handler.Request!.RequestUri!.PathAndQuery.Should().Be("/v1/messages");
        handler.Request.Headers.Accept.ToString().Should().Contain("text/event-stream");
        string.Join(",", handler.Request.Headers.GetValues("anthropic-beta"))
            .Should().Be("fast-mode-2026-02-01");
        // The caller never sets it; the generated method does.
        handler.RequestBody.Should().Contain("\"stream\":true");

        events.Should().HaveCount(1);
    }

    [TestMethod]
    public async Task SessionEventStreamSendsTheManagedAgentsBetaByDefault()
    {
        var handler = new SseHandler(string.Empty);
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://api.anthropic.com"),
        };
        using var client = new AnthropicClient(httpClient, authorizations: null, options: null);

        await foreach (var _ in client.StreamSessionEventsAsStreamAsync(
            sessionId: "sess_01",
            eventDeltas: [BetaManagedAgentsEventDeltaType.AgentMessage]))
        {
            Assert.Fail("the stub stream yields nothing");
        }

        handler.Request.Should().NotBeNull();
        handler.Request!.RequestUri!.AbsolutePath.Should().Be("/v1/sessions/sess_01/events/stream");
        handler.Request.RequestUri.Query.Should().Contain("event_deltas");
        // The endpoint rejects the request without this flag, and the specification does not imply
        // it - the wrapper supplies it.
        string.Join(",", handler.Request.Headers.GetValues("anthropic-beta"))
            .Should().Be("managed-agents-2026-04-01");
    }

    private sealed class SseHandler(string body) : HttpMessageHandler
    {
        public HttpRequestMessage? Request { get; private set; }

        public string? RequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Request = request;
            if (request.Content is not null)
            {
                RequestBody = await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            }

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(body, System.Text.Encoding.UTF8, "text/event-stream"),
            };
        }
    }
}
