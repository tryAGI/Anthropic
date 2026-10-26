using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Anthropic.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow("temperature")]
    [DataRow("top_p")]
    [DataRow("top_k")]
    public async Task ChatClientRejectsRemovedSamplingOptionsBeforeSending(string parameter)
    {
        using var http = new HttpClient(new RejectUnexpectedRequestHandler());
        using var client = new AnthropicClient(httpClient: http);
        IChatClient chat = client;
        var options = new ChatOptions { ModelId = "fixture" };
        switch (parameter)
        {
            case "temperature": options.Temperature = 0.5f; break;
            case "top_p": options.TopP = 0.5f; break;
            case "top_k": options.TopK = 10; break;
        }

        await Assert.ThrowsExactlyAsync<NotSupportedException>(async () =>
            await chat.GetResponseAsync([new ChatMessage(ChatRole.User, "hello")], options));
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task ChatClientRejectsAssistantDocumentsBeforeSending(bool useUri)
    {
        using var http = new HttpClient(new RejectUnexpectedRequestHandler());
        using var client = new AnthropicClient(httpClient: http);
        IChatClient chat = client;
        AIContent content = useUri
            ? new UriContent(new Uri("https://example.invalid/document.pdf"), "application/pdf")
            : new DataContent(new byte[] { 1, 2, 3 }, "application/pdf");

        await Assert.ThrowsExactlyAsync<NotSupportedException>(async () =>
            await chat.GetResponseAsync([new ChatMessage(ChatRole.Assistant, [content])],
                new ChatOptions { ModelId = "fixture" }));
    }

    [TestMethod]
    public async Task ChatClientSendsCurrentVersionAndRoleSpecificMessages()
    {
        using var http = new HttpClient(new CurrentVersionHandler());
        using var client = new AnthropicClient(httpClient: http, authorizations:
        [new EndPointAuthorization { Type = "ApiKey", Location = "Header", Name = "x-api-key", Value = "offline" }]);
        IChatClient chat = client;

        var response = await chat.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "hello"), new ChatMessage(ChatRole.Assistant, "previous")],
            new ChatOptions { ModelId = "fixture", MaxOutputTokens = 32 });

        response.Text.Should().Be("ok");
    }

    [TestMethod]
    public void RoleSpecificHelpersPreserveTextAndWireRoles()
    {
        InputMessageUnion user = "hello";
        var assistant = "reply".AsAssistantMessage();
        var system = InputMessageUnion.FromSystem(new SystemInputMessage { Content = "instructions" });

        user.IsUser.Should().BeTrue();
        assistant.IsAssistant.Should().BeTrue();
        user.AsSimpleText().Should().Be("hello");
        assistant.AsSimpleText().Should().Be("reply");
        system.AsSimpleText().Should().Be("instructions");
        InputMessageUnion.FromJson(assistant.ToJson())!.Value.AsSimpleText().Should().Be("reply");
    }

    private sealed class RejectUnexpectedRequestHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
            throw new InvalidOperationException("The unsupported request reached the HTTP transport.");
    }

    private sealed class CurrentVersionHandler : HttpMessageHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.GetValues("anthropic-version").Single().Should().Be("2026-10-21");
            using var document = JsonDocument.Parse(await request.Content!.ReadAsStringAsync(cancellationToken));
            var root = document.RootElement;
            root.GetProperty("messages")[0].GetProperty("role").GetString().Should().Be("user");
            root.GetProperty("messages")[1].GetProperty("role").GetString().Should().Be("assistant");
            foreach (var removed in new[] { "temperature", "top_p", "top_k" })
                root.TryGetProperty(removed, out _).Should().BeFalse();
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""{"id":"msg_fixture","type":"message","role":"assistant","content":[{"type":"text","text":"ok"}],"model":"fixture","stop_reason":"end_turn","usage":{"input_tokens":1,"output_tokens":1}}""", Encoding.UTF8, "application/json"),
            };
        }
    }
}
