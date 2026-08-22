#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Work Items<br/>
        /// Note: these endpoints are called automatically by the pre-built environment worker provided in the SDKs and CLI, for orchestrating sessions with self-hosted sandbox environments. They are included here as a reference; you do not need to invoke them directly.<br/>
        /// List work items in an environment.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="limit">
        /// Maximum number of work items to return<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from previous response for pagination
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaSelfHostedWorkListResponse> BetaListWorkV1EnvironmentsEnvironmentIdWorkGetAsync(
            string environmentId,
            int? limit = default,
            string? page = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? authorization = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Work Items<br/>
        /// Note: these endpoints are called automatically by the pre-built environment worker provided in the SDKs and CLI, for orchestrating sessions with self-hosted sandbox environments. They are included here as a reference; you do not need to invoke them directly.<br/>
        /// List work items in an environment.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="limit">
        /// Maximum number of work items to return<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor from previous response for pagination
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaSelfHostedWorkListResponse>> BetaListWorkV1EnvironmentsEnvironmentIdWorkGetAsResponseAsync(
            string environmentId,
            int? limit = default,
            string? page = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? authorization = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListWorkV1EnvironmentsEnvironmentIdWorkGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaSelfHostedWork&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="limit">
        /// Maximum number of work items to return<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="authorization"></param> 
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaSelfHostedWork> BetaListWorkV1EnvironmentsEnvironmentIdWorkGetAutoPagingAsync(
            string environmentId,             int? limit = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? authorization = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}