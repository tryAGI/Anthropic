using System.Text.Json;
using System.Net;
using System.Net.Http;

namespace Anthropic.IntegrationTests;

/// <summary>
/// An error response is not always JSON. A gateway or load balancer in front of the API answers
/// with its own page, and the caller still has to get a usable exception out of it.
/// </summary>
/// <remarks>
/// This is not hypothetical: Polar answers every credential-less request with a Tomcat HTML 401,
/// and D-ID's AWS gateway answers a malformed Authorization header with a JSON body that does not
/// match D-ID's own error schema. Whatever the body is, the caller should get the typed exception
/// with the body attached - not a JSON parse error from inside the SDK.
/// </remarks>
public partial class Tests
{
    private const string HtmlErrorBody =
        """
        <!doctype html><html lang="en"><head><title>HTTP Status 401 - Unauthorized</title></head>
        <body><h1>HTTP Status 401 - Unauthorized</h1></body></html>
        """;

    [TestMethod]
    public async Task GeneratedOperationSurfacesAnHtmlErrorBody()
    {
        using var httpClient = new HttpClient(new StatusHandler(HttpStatusCode.Unauthorized, HtmlErrorBody, "text/html"))
        {
            BaseAddress = new Uri("https://api.anthropic.com"),
        };
        using var client = new AnthropicClient(httpClient, authorizations: null, options: null);

        try
        {
            _ = await client.ModelsListAsync(limit: 1);
            Assert.Fail("expected the call to throw");
        }
        catch (ApiException<ErrorResponse> ex)
        {
            ex.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
            ex.ResponseBody.Should().Contain("HTTP Status 401");
            // The body could not be parsed, so there is no typed error object - and the parse
            // failure is kept as the inner exception rather than thrown at the caller.
            ex.ResponseObject.Should().BeNull();
            ex.InnerException.Should().BeOfType<JsonException>();
        }
    }

    [TestMethod]
    public async Task StreamingSurfacesAnHtmlErrorBody()
    {
        using var httpClient = new HttpClient(new StatusHandler(HttpStatusCode.Unauthorized, HtmlErrorBody, "text/html"))
        {
            BaseAddress = new Uri("https://api.anthropic.com"),
        };
        using var client = new AnthropicClient(httpClient, authorizations: null, options: null)
        {
            ReadResponseAsString = true,
        };

        var enumerable = client.CreateMessageAsStreamAsync(new CreateMessageParams
        {
            Model = "claude-haiku-5-5",
            MaxTokens = 16,
            Messages = ["hi"],
        });

        try
        {
            await foreach (var _ in enumerable)
            {
                Assert.Fail("expected the stream to throw before yielding");
            }

            Assert.Fail("expected the stream to throw");
        }
        catch (ApiException<ErrorResponse> ex)
        {
            ex.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
            ex.ResponseBody.Should().Contain("HTTP Status 401");
            ex.ResponseObject.Should().BeNull();
        }
    }

    private sealed class StatusHandler(HttpStatusCode statusCode, string body, string contentType) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(body, System.Text.Encoding.UTF8, contentType),
            });
        }
    }
}
