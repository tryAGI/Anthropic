#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Organization Rate Limits<br/>
        /// List Messages API rate limits for your organization.<br/>
        /// Each entry corresponds to one rate-limit group (either a model family<br/>
        /// or an API-surface category such as the Files API or Message Batches)<br/>
        /// and contains the set of limiter values that apply to it.<br/>
        /// When `limit` is omitted, every matching entry is returned in a single<br/>
        /// page; when `limit` truncates the result, follow `next_page` to fetch<br/>
        /// the remaining entries.
        /// </summary>
        /// <param name="model">
        /// Filter to the single entry containing this model. Accepts full model names and aliases. Returns 404 if the model is not found or has no rate limits for this organization.
        /// </param>
        /// <param name="groupType">
        /// Filter by group type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return per page. Ranges from `1` to `1000`.<br/>
        /// When omitted, every remaining entry is returned in a single page and `next_page` is `null`.
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaRateLimitListResponse> BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetAsync(
            string? model = default,
            global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2? groupType = default,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organization Rate Limits<br/>
        /// List Messages API rate limits for your organization.<br/>
        /// Each entry corresponds to one rate-limit group (either a model family<br/>
        /// or an API-surface category such as the Files API or Message Batches)<br/>
        /// and contains the set of limiter values that apply to it.<br/>
        /// When `limit` is omitted, every matching entry is returned in a single<br/>
        /// page; when `limit` truncates the result, follow `next_page` to fetch<br/>
        /// the remaining entries.
        /// </summary>
        /// <param name="model">
        /// Filter to the single entry containing this model. Accepts full model names and aliases. Returns 404 if the model is not found or has no rate limits for this organization.
        /// </param>
        /// <param name="groupType">
        /// Filter by group type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return per page. Ranges from `1` to `1000`.<br/>
        /// When omitted, every remaining entry is returned in a single page and `next_page` is `null`.
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page`.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaRateLimitListResponse>> BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetAsResponseAsync(
            string? model = default,
            global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2? groupType = default,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaRateLimit&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="model">
        /// Filter to the single entry containing this model. Accepts full model names and aliases. Returns 404 if the model is not found or has no rate limits for this organization.
        /// </param>
        /// <param name="groupType">
        /// Filter by group type.
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return per page. Ranges from `1` to `1000`.<br/>
        /// When omitted, every remaining entry is returned in a single page and `next_page` is `null`.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaRateLimit> BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetAutoPagingAsync(
              string? model = default,
            global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType2? groupType = default,
            int? limit = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}