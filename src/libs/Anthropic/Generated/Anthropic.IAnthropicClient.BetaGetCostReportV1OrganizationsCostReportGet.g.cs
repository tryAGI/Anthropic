#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Cost Report
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaGetCostReportResponse> BetaGetCostReportV1OrganizationsCostReportGetAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? groupBy = default,
            global::Anthropic.BetaCostReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cost Report
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetCostReportResponse>> BetaGetCostReportV1OrganizationsCostReportGetAsResponseAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? groupBy = default,
            global::Anthropic.BetaCostReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetCostReportV1OrganizationsCostReportGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaCostReportTimeBucket&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaCostReportTimeBucket> BetaGetCostReportV1OrganizationsCostReportGetAutoPagingAsync(
            global::System.DateTime startingAt,             int? limit = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportGroupBy>? groupBy = default,
            global::Anthropic.BetaCostReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}