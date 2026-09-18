#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Acknowledge Work<br/>
        /// Note: these endpoints are called automatically by the pre-built environment worker provided in the SDKs and CLI, for orchestrating sessions with self-hosted sandbox environments. They are included here as a reference; you do not need to invoke them directly.<br/>
        /// Acknowledge receipt of a work item, transitioning it from 'queued' to 'starting' and removing it from the queue.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="workId"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSelfHostedWork> BetaAcknowledgeWorkV1EnvironmentsEnvironmentIdWorkWorkIdAckPostAsync(
            string environmentId,
            string workId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? authorization = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Acknowledge Work<br/>
        /// Note: these endpoints are called automatically by the pre-built environment worker provided in the SDKs and CLI, for orchestrating sessions with self-hosted sandbox environments. They are included here as a reference; you do not need to invoke them directly.<br/>
        /// Acknowledge receipt of a work item, transitioning it from 'queued' to 'starting' and removing it from the queue.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="workId"></param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSelfHostedWork>> BetaAcknowledgeWorkV1EnvironmentsEnvironmentIdWorkWorkIdAckPostAsResponseAsync(
            string environmentId,
            string workId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? authorization = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}