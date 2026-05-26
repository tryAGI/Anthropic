#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Skills
        /// </summary>
        /// <param name="page">
        /// Pagination token for fetching a specific page of results.<br/>
        /// Pass the value from a previous response's `next_page` field to get the next page of results.
        /// </param>
        /// <param name="limit">
        /// Number of results to return per page.<br/>
        /// Maximum value is 100. Defaults to 20.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="source">
        /// Filter skills by source.<br/>
        /// If provided, only skills from the specified source will be returned:<br/>
        /// * `"custom"`: only return user-created skills<br/>
        /// * `"anthropic"`: only return Anthropic-created skills
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaListSkillsResponse> BetaListSkillsV1SkillsGetAsync(
            string? page = default,
            int? limit = default,
            string? source = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Skills
        /// </summary>
        /// <param name="page">
        /// Pagination token for fetching a specific page of results.<br/>
        /// Pass the value from a previous response's `next_page` field to get the next page of results.
        /// </param>
        /// <param name="limit">
        /// Number of results to return per page.<br/>
        /// Maximum value is 100. Defaults to 20.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="source">
        /// Filter skills by source.<br/>
        /// If provided, only skills from the specified source will be returned:<br/>
        /// * `"custom"`: only return user-created skills<br/>
        /// * `"anthropic"`: only return Anthropic-created skills
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaListSkillsResponse>> BetaListSkillsV1SkillsGetAsResponseAsync(
            string? page = default,
            int? limit = default,
            string? source = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaListSkillsV1SkillsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaapiSchemasSkillsSkill&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Number of results to return per page.<br/>
        /// Maximum value is 100. Defaults to 20.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="source">
        /// Filter skills by source.<br/>
        /// If provided, only skills from the specified source will be returned:<br/>
        /// * `"custom"`: only return user-created skills<br/>
        /// * `"anthropic"`: only return Anthropic-created skills
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.claude.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param> 
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaapiSchemasSkillsSkill> BetaListSkillsV1SkillsGetAutoPagingAsync(
              int? limit = default,
            string? source = default,
            string? anthropicBeta = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}