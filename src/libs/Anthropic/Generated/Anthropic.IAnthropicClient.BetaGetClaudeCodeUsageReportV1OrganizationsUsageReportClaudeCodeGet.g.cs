#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Claude Code Usage Report<br/>
        /// Retrieve daily aggregated usage metrics for Claude Code users.<br/>
        /// Enables organizations to analyze developer productivity and build custom dashboards.
        /// </summary>
        /// <param name="startingAt">
        /// UTC date in YYYY-MM-DD format. Returns metrics for this single day only.
        /// </param>
        /// <param name="limit">
        /// Number of records per page (default: 20, max: 1000).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor token from previous response's `next_page` field.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaGetClaudeCodeUsageReportResponse> BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Claude Code Usage Report<br/>
        /// Retrieve daily aggregated usage metrics for Claude Code users.<br/>
        /// Enables organizations to analyze developer productivity and build custom dashboards.
        /// </summary>
        /// <param name="startingAt">
        /// UTC date in YYYY-MM-DD format. Returns metrics for this single day only.
        /// </param>
        /// <param name="limit">
        /// Number of records per page (default: 20, max: 1000).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="page">
        /// Opaque cursor token from previous response's `next_page` field.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetClaudeCodeUsageReportResponse>> BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsResponseAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaClaudeCodeUsageReportItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="startingAt">
        /// UTC date in YYYY-MM-DD format. Returns metrics for this single day only.
        /// </param>
        /// <param name="limit">
        /// Number of records per page (default: 20, max: 1000).<br/>
        /// Default Value: 20
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaClaudeCodeUsageReportItem> BetaGetClaudeCodeUsageReportV1OrganizationsUsageReportClaudeCodeGetAutoPagingAsync(
            global::System.DateTime startingAt,             int? limit = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}