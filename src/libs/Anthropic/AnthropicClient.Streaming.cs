// ReSharper disable RedundantNameQualifier

namespace Anthropic;

public partial class AnthropicClient
{
    /// <summary>
    /// Create a Message and stream the response.
    /// </summary>
    /// <remarks>
    /// Kept as the name consumers already use. The transport is generated: the specification now
    /// declares <c>text/event-stream</c> on the 200 response, so <c>MessagesPostAsStreamAsync</c>
    /// carries the retry, timeout, request-option and hook behaviour every other operation has.
    /// </remarks>
    /// <param name="request">The message request. <c>stream</c> is set automatically.</param>
    /// <param name="anthropicVersion">The version of the Claude API you want to use.</param>
    /// <param name="cancellationToken">The token to cancel the operation with</param>
    /// <exception cref="global::Anthropic.ApiException"></exception>
    public global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.MessageStreamEvent> CreateMessageAsStreamAsync(
        global::Anthropic.CreateMessageParams request,
        string? anthropicVersion = default,
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        return MessagesPostAsStreamAsync(
            request: request,
            anthropicVersion: anthropicVersion,
            cancellationToken: cancellationToken);
    }
}
