#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Cost Report<br/>
        /// [Legacy] Get a report of your organization's Claude API costs in USD, aggregated into daily buckets.<br/>
        /// This endpoint is part of the legacy Usage and Cost API. For new integrations, use [`GET /v1/organizations/analytics/cost`](/docs/en/api/beta/organization/analytics/cost/list) in the Usage and Cost Analytics API instead. To move an existing integration, see [Migrate from the Usage and Cost API](/docs/en/manage-claude/usage-cost-analytics-api#migrate-from-usage-cost-api).
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
        /// Optional header to specify the beta version(s) you want to use.
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
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Cost Report<br/>
        /// [Legacy] Get a report of your organization's Claude API costs in USD, aggregated into daily buckets.<br/>
        /// This endpoint is part of the legacy Usage and Cost API. For new integrations, use [`GET /v1/organizations/analytics/cost`](/docs/en/api/beta/organization/analytics/cost/list) in the Usage and Cost Analytics API instead. To move an existing integration, see [Migrate from the Usage and Cost API](/docs/en/manage-claude/usage-cost-analytics-api#migrate-from-usage-cost-api).
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
        /// Optional header to specify the beta version(s) you want to use.
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
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
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
        /// Optional header to specify the beta version(s) you want to use.
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
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}