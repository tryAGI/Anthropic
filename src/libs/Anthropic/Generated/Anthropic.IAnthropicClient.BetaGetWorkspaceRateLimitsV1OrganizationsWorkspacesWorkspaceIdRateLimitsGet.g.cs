#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// List Workspace Rate Limits<br/>
        /// List rate-limit overrides configured for a workspace.<br/>
        /// Returns only the groups and limiter types that have a workspace-level<br/>
        /// override. Groups without overrides inherit the organization limits and<br/>
        /// are not listed; use `GET /v1/organizations/rate_limits` to see those.<br/>
        /// When `limit` is omitted, every matching entry is returned in a single<br/>
        /// page; when `limit` truncates the result, follow `next_page` to fetch<br/>
        /// the remaining entries.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaWorkspaceRateLimitListResponse> BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetAsync(
            string workspaceId,
            global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2? groupType = default,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Workspace Rate Limits<br/>
        /// List rate-limit overrides configured for a workspace.<br/>
        /// Returns only the groups and limiter types that have a workspace-level<br/>
        /// override. Groups without overrides inherit the organization limits and<br/>
        /// are not listed; use `GET /v1/organizations/rate_limits` to see those.<br/>
        /// When `limit` is omitted, every matching entry is returned in a single<br/>
        /// page; when `limit` truncates the result, follow `next_page` to fetch<br/>
        /// the remaining entries.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaWorkspaceRateLimitListResponse>> BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetAsResponseAsync(
            string workspaceId,
            global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2? groupType = default,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaWorkspaceRateLimit&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaWorkspaceRateLimit> BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetAutoPagingAsync(
            string workspaceId,             global::Anthropic.BetaGetWorkspaceRateLimitsV1OrganizationsWorkspacesWorkspaceIdRateLimitsGetGroupType2? groupType = default,
            int? limit = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}