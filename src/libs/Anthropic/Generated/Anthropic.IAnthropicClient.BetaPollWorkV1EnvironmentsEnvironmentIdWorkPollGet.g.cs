#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Poll for Work<br/>
        /// Note: these endpoints are called automatically by the pre-built environment worker provided in the SDKs and CLI, for orchestrating sessions with self-hosted sandbox environments. They are included here as a reference; you do not need to invoke them directly.<br/>
        /// Long poll for work items in the queue.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="blockMs">
        /// How long to wait for work to arrive before returning. Must be 1-999 in milliseconds. Defaults to non-blocking (returns immediately if no work is available).
        /// </param>
        /// <param name="reclaimOlderThanMs">
        /// Reclaim unacknowledged work items older than this many milliseconds. If omitted, uses the default (5000ms).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkerId">
        /// Unique identifier for the specific worker polling, used to track aggregated environment-level work metrics in Console
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSelfHostedWork> BetaPollWorkV1EnvironmentsEnvironmentIdWorkPollGetAsync(
            string environmentId,
            int? blockMs = default,
            int? reclaimOlderThanMs = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkerId = default,
            string? authorization = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll for Work<br/>
        /// Note: these endpoints are called automatically by the pre-built environment worker provided in the SDKs and CLI, for orchestrating sessions with self-hosted sandbox environments. They are included here as a reference; you do not need to invoke them directly.<br/>
        /// Long poll for work items in the queue.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="blockMs">
        /// How long to wait for work to arrive before returning. Must be 1-999 in milliseconds. Defaults to non-blocking (returns immediately if no work is available).
        /// </param>
        /// <param name="reclaimOlderThanMs">
        /// Reclaim unacknowledged work items older than this many milliseconds. If omitted, uses the default (5000ms).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkerId">
        /// Unique identifier for the specific worker polling, used to track aggregated environment-level work metrics in Console
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSelfHostedWork>> BetaPollWorkV1EnvironmentsEnvironmentIdWorkPollGetAsResponseAsync(
            string environmentId,
            int? blockMs = default,
            int? reclaimOlderThanMs = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkerId = default,
            string? authorization = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}