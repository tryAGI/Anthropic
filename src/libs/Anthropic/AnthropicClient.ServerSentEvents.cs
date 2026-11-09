using System.Net.Http.Headers;
using System.Net.ServerSentEvents;
using System.Runtime.CompilerServices;

// ReSharper disable RedundantNameQualifier

namespace Anthropic;

public partial class AnthropicClient
{
    /// <summary>
    /// Sends a request and streams back the raw `data:` payload of every server-sent event.
    /// </summary>
    /// <remarks>
    /// The OpenAPI specification models every streaming endpoint as a single JSON response, so the
    /// generated methods cannot expose them as streams. This is the shared transport used by the
    /// hand-written streaming overloads.
    /// </remarks>
    private async IAsyncEnumerable<string> SendServerSentEventsAsync(
        global::System.Net.Http.HttpMethod method,
        string path,
        string? jsonBody = null,
        global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = null,
        string? anthropicVersion = null,
        string? anthropicUserProfileId = null,
        string? anthropicWorkspaceId = null,
        [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
    {
        PrepareArguments(
            client: HttpClient);

        var __pathBuilder = new global::Anthropic.PathBuilder(
            path: path,
            baseUri: HttpClient.BaseAddress);
        using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
            method: method,
            requestUri: new global::System.Uri(__pathBuilder.ToString(), global::System.UriKind.RelativeOrAbsolute));
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

        if (anthropicBeta is { Count: > 0 })
        {
            __httpRequest.Headers.TryAddWithoutValidation(
                "anthropic-beta",
                string.Join(",", anthropicBeta.Select(static x => x.ToString() ?? string.Empty)));
        }
        if (anthropicVersion != default)
        {
            __httpRequest.Headers.TryAddWithoutValidation("anthropic-version", anthropicVersion);
        }
        if (anthropicUserProfileId != default)
        {
            __httpRequest.Headers.TryAddWithoutValidation("anthropic-user-profile-id", anthropicUserProfileId);
        }
        if (anthropicWorkspaceId != default)
        {
            __httpRequest.Headers.TryAddWithoutValidation("anthropic-workspace-id", anthropicWorkspaceId);
        }

        if (jsonBody is not null)
        {
            __httpRequest.Content = new global::System.Net.Http.StringContent(
                content: jsonBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
        }

        global::Anthropic.AutoSDKRequestOptionsSupport.ApplyHeaders(
            request: __httpRequest,
            clientHeaders: Options.Headers,
            requestHeaders: null);

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

        await EnsureStreamingResponseAsync(__response, cancellationToken).ConfigureAwait(false);

#if NET6_0_OR_GREATER
        using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
        using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif

        await foreach (SseItem<string> sseEvent in SseParser.Create(__content)
                           .EnumerateAsync(cancellationToken)
                           .ConfigureAwait(false))
        {
            yield return sseEvent.Data;
        }
    }

    /// <summary>
    /// Throws a typed <see cref="ApiException"/> when a streaming response did not start successfully.
    /// </summary>
    private async global::System.Threading.Tasks.Task EnsureStreamingResponseAsync(
        global::System.Net.Http.HttpResponseMessage response,
        global::System.Threading.CancellationToken cancellationToken)
    {
        if ((int)response.StatusCode is >= 400 and <= 499)
        {
            var serializerContext = JsonSerializerContextProvider?.Value;
            string? __content = null;
            global::Anthropic.ErrorResponse? __value = null;
            if (ReadResponseAsString)
            {
                __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                __value = serializerContext is null
                    ? global::Anthropic.ErrorResponse.FromJson(__content)
                    : global::Anthropic.ErrorResponse.FromJson(__content, serializerContext);
            }
            else
            {
                var __contentStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                __value = serializerContext is null
                    ? await global::Anthropic.ErrorResponse.FromJsonStreamAsync(__contentStream).ConfigureAwait(false)
                    : await global::Anthropic.ErrorResponse.FromJsonStreamAsync(__contentStream, serializerContext).ConfigureAwait(false);
            }

            throw new global::Anthropic.ApiException<global::Anthropic.ErrorResponse>(
                message: response.ReasonPhrase ?? string.Empty,
                statusCode: response.StatusCode)
            {
                ResponseBody = __content,
                ResponseObject = __value,
                ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                    response.Headers,
                    h => h.Key,
                    h => h.Value),
            };
        }

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (global::System.Net.Http.HttpRequestException __ex)
        {
            throw new global::Anthropic.ApiException(
                message: response.ReasonPhrase ?? string.Empty,
                innerException: __ex,
                statusCode: response.StatusCode)
            {
                ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                    response.Headers,
                    h => h.Key,
                    h => h.Value),
            };
        }
    }
}
