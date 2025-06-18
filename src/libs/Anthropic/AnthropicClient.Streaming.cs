using System.Net.Http.Headers;
using System.Net.ServerSentEvents;
using System.Runtime.CompilerServices;

// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming

namespace Anthropic;

public partial class AnthropicClient
{
    /// <summary>
    /// Create a Message<br/>
    /// Send a structured list of input messages with text and/or image content, and the model will generate the next message in the conversation.<br/>
    /// The Messages API can be used for either single queries or stateless multi-turn conversations.
    /// </summary>
    /// <param name="anthropicVersion">
    /// The version of the Anthropic API you want to use.<br/>
    /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
    /// </param>
    /// <param name="request"></param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::Anthropic.ApiException"></exception>
    public async IAsyncEnumerable<global::Anthropic.MessageStreamEvent> CreateMessageAsStreamAsync(
        global::Anthropic.CreateMessageParams request,
        string? anthropicVersion = default,
        [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
    {
        request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        request.Stream = true;

        PrepareArguments(
            client: HttpClient);

        var __pathBuilder = new PathBuilder(
            path: "/v1/messages",
            baseUri: HttpClient.BaseAddress); 
        var __path = __pathBuilder.ToString();
        using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
            method: global::System.Net.Http.HttpMethod.Post,
            requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
        __httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/event-stream"));
#if NET6_0_OR_GREATER
        __httpRequest.Version = global::System.Net.HttpVersion.Version11;
        __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

        foreach (var __authorization in Authorizations)
        {
            if (__authorization.Type == "Http" ||
                __authorization.Type == "OAuth2")
            {
                __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: __authorization.Name,
                    parameter: __authorization.Value);
            }
            else if (__authorization.Type == "ApiKey" &&
                     __authorization.Location == "Header")
            {
                __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
            }
        }

        if (anthropicVersion != default)
        {
            __httpRequest.Headers.TryAddWithoutValidation("anthropic-version", anthropicVersion.ToString());
        }

        var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
        var __httpRequestContent = new global::System.Net.Http.StringContent(
            content: __httpRequestContentBody,
            encoding: global::System.Text.Encoding.UTF8,
            mediaType: "application/json");
        __httpRequest.Content = __httpRequestContent;

        PrepareRequest(
            client: HttpClient,
            request: __httpRequest);

        using var __response = await HttpClient.SendAsync(
            request: __httpRequest,
            completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        ProcessResponse(
            client: HttpClient,
            response: __response);
        // Error response.  See our [errors documentation](https://docs.anthropic.com/en/api/errors) for more details.
        if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
        {
            string? __content_4XX = null;
            global::Anthropic.ErrorResponse? __value_4XX = null;
            if (ReadResponseAsString)
            {
                __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                __value_4XX = global::Anthropic.ErrorResponse.FromJson(__content_4XX, JsonSerializerContext);
            }
            else
            {
                var __contentStream_4XX = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                __value_4XX = await global::Anthropic.ErrorResponse.FromJsonStreamAsync(__contentStream_4XX, JsonSerializerContext).ConfigureAwait(false);
            }
        
            throw new global::Anthropic.ApiException<global::Anthropic.ErrorResponse>(
                message: __response.ReasonPhrase ?? string.Empty,
                statusCode: __response.StatusCode)
            {
                ResponseBody = __content_4XX,
                ResponseObject = __value_4XX,
                ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                    __response.Headers,
                    h => h.Key,
                    h => h.Value),
            };
        }
        
        try
        {
            __response.EnsureSuccessStatusCode();
        }
        catch (global::System.Net.Http.HttpRequestException __ex)
        {
            throw new global::Anthropic.ApiException(
                message: __response.ReasonPhrase ?? string.Empty,
                innerException: __ex,
                statusCode: __response.StatusCode)
            {
                ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                    __response.Headers,
                    h => h.Key,
                    h => h.Value),
            };
        }
        
#if NET6_0_OR_GREATER
        using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
        using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif

        await foreach (SseItem<string> sseEvent in SseParser.Create(__content)
                           .EnumerateAsync(cancellationToken)
                           .ConfigureAwait(false))
        {
            // When the response is good, each SSE line contains a serialized MessageStreamEvent
            var block = JsonSerializer.Deserialize(sseEvent.Data, SourceGenerationContext.Default.NullableMessageStreamEvent);
            if (block == null)
            {
                yield break;
            }
            
            yield return block.Value;
        }
    }
}
