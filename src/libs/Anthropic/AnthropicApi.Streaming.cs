using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming

namespace Anthropic;

public partial class AnthropicApi
{
    /// <summary>
    /// Create a Message<br/>
    /// Send a structured list of input messages with text and/or image content, and the<br/>
    /// model will generate the next message in the conversation.<br/>
    /// The Messages API can be used for either single queries or stateless multi-turn<br/>
    /// conversations.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::System.InvalidOperationException"></exception>
    public async IAsyncEnumerable<global::Anthropic.MessageStreamEvent> CreateMessageAsStreamAsync(
        global::Anthropic.CreateMessageRequest request,
        [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
    {
        request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        request.Stream = true;
        
        PrepareArguments(
            client: _httpClient);
        PrepareCreateMessageArguments(
            httpClient: _httpClient,
            request: request);

        using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
            method: global::System.Net.Http.HttpMethod.Post,
            requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/messages", global::System.UriKind.RelativeOrAbsolute));
        var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::Anthropic.SourceGenerationContext.Default.CreateMessageRequest);
        httpRequest.Content = new global::System.Net.Http.StringContent(
            content: __json,
            encoding: global::System.Text.Encoding.UTF8,
            mediaType: "application/json");
        httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("text/event-stream"));

        PrepareRequest(
            client: _httpClient,
            request: httpRequest);
        PrepareCreateMessageRequest(
            httpClient: _httpClient,
            httpRequestMessage: httpRequest,
            request: request);

        using var response = await _httpClient.SendAsync(
            request: httpRequest,
            completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        ProcessResponse(
            client: _httpClient,
            response: response);
        ProcessCreateMessageResponse(
            httpClient: _httpClient,
            httpResponseMessage: response);

#if NET6_0_OR_GREATER
        using var __content = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
        using var __content = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif
        using var reader = new StreamReader(__content);

        // Continuously read the stream until the end of it
        while (!reader.EndOfStream)
        {
            cancellationToken.ThrowIfCancellationRequested();

#if NET7_0_OR_GREATER
            var line = await reader.ReadLineAsync(cancellationToken).ConfigureAwait(false);
#else
            var line = await reader.ReadLineAsync().ConfigureAwait(false);
#endif
            
            // Skip empty lines
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            var index = line.IndexOf('{');
            if (index >= 0)
            {
                line = line[index..];
            }

            if (line.StartsWith("event: ", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            MessageStreamEvent? block = null;
            try
            {
                // When the response is good, each line is a serializable CompletionCreateRequest
                block = JsonSerializer.Deserialize(line, SourceGenerationContext.Default.NullableMessageStreamEvent);
            }
            catch (JsonException)
            {
                // When the API returns an error, it does not come back as a block, it returns a single character of text ("{").
                // In this instance, read through the rest of the response, which should be a complete object to parse.
#if NET7_0_OR_GREATER
                line += await reader.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
#else
                line += await reader.ReadToEndAsync().ConfigureAwait(false);
#endif
            }

            if (block == null)
            {
                yield break;
            }
            
            yield return block.Value;
        }
    }
}
