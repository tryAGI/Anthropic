#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Stream Session Thread Events
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="threadId"></param>
        /// <param name="eventDeltas"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents> BetaStreamSessionThreadEventsAsync(
            string sessionId,
            string threadId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Session Thread Events
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="anthropicVersion"></param>
        /// <param name="anthropicBeta"></param>
        /// <param name="sessionId"></param>
        /// <param name="threadId"></param>
        /// <param name="eventDeltas"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaManagedAgentsStreamSessionThreadEvents>> BetaStreamSessionThreadEventsAsResponseAsync(
            string sessionId,
            string threadId,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? anthropicBeta = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventDeltaType>? eventDeltas = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}