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

        var serializerContext = JsonSerializerContextProvider?.Value;
        var body = serializerContext is null
            ? request.ToJson()
            : request.ToJson(serializerContext);

        var events = SendServerSentEventsAsync(
            method: global::System.Net.Http.HttpMethod.Post,
            path: "/v1/messages",
            jsonBody: body,
            anthropicVersion: anthropicVersion,
            cancellationToken: cancellationToken);

        await foreach (var data in events.ConfigureAwait(false))
        {
            // When the response is good, each SSE line contains a serialized MessageStreamEvent
            var block = serializerContext is null
                ? MessageStreamEvent.FromJson(data)
                : MessageStreamEvent.FromJson(data, serializerContext);
            if (block == null)
            {
                yield break;
            }

            yield return block.Value;
        }
    }
}
