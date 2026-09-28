#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Activity Summaries<br/>
        /// Get organization-wide activity summaries for a date range.<br/>
        /// Returns one entry per day from `starting_date` (inclusive) to `ending_date`<br/>
        /// (exclusive) in `data`, the same `data` / `next_page` envelope as the other<br/>
        /// analytics list endpoints; the series is currently returned in full, so<br/>
        /// `next_page` is always null (`summaries` is a deprecated alias of `data`).<br/>
        /// Data is typically available with a 1-day lag and may be revised by a few<br/>
        /// percent over the following days: when `ending_date` is omitted it<br/>
        /// defaults to the most recent available day + 1, so the last entry covers<br/>
        /// the most recent available day. The series can be scoped to an RBAC group<br/>
        /// via `filter[]=rbac_group_id:{id}`. Available to organizations on a Claude<br/>
        /// Enterprise plan. Requires an API key with the `read:analytics` scope.
        /// </summary>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of the date range (inclusive). Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive). Data is typically available with a 1-day lag, so this can be at most today — which is also the default when omitted, making the last entry cover the most recent available day. Data may be revised by a few percent over the following days. The range may span at most 366 days.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100). The day series (at most 366 entries) is currently returned in full in a single page, so `limit` does not yet shorten it.
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field. `next_page` is currently always null, so there is never a cursor to send.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`. Only `rbac_group_id` is supported (e.g. `filter[]=rbac_group_id:{id}`); repeat the param to OR across groups. Scopes the whole day series to members of the matching group(s), re-aggregated from member-level activity — org-wide seat/invite fields and the adoption rates derived from them are null on scoped rows. `rbac_group_id` accepts the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each UTC day (time-of-usage attribution). At most 100 entries.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsActivitySummaryResponse> BetaGetSummariesV1OrganizationsAnalyticsSummariesGetAsync(
            global::System.DateTime startingDate,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Activity Summaries<br/>
        /// Get organization-wide activity summaries for a date range.<br/>
        /// Returns one entry per day from `starting_date` (inclusive) to `ending_date`<br/>
        /// (exclusive) in `data`, the same `data` / `next_page` envelope as the other<br/>
        /// analytics list endpoints; the series is currently returned in full, so<br/>
        /// `next_page` is always null (`summaries` is a deprecated alias of `data`).<br/>
        /// Data is typically available with a 1-day lag and may be revised by a few<br/>
        /// percent over the following days: when `ending_date` is omitted it<br/>
        /// defaults to the most recent available day + 1, so the last entry covers<br/>
        /// the most recent available day. The series can be scoped to an RBAC group<br/>
        /// via `filter[]=rbac_group_id:{id}`. Available to organizations on a Claude<br/>
        /// Enterprise plan. Requires an API key with the `read:analytics` scope.
        /// </summary>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of the date range (inclusive). Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive). Data is typically available with a 1-day lag, so this can be at most today — which is also the default when omitted, making the last entry cover the most recent available day. Data may be revised by a few percent over the following days. The range may span at most 366 days.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100). The day series (at most 366 entries) is currently returned in full in a single page, so `limit` does not yet shorten it.
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field. `next_page` is currently always null, so there is never a cursor to send.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`. Only `rbac_group_id` is supported (e.g. `filter[]=rbac_group_id:{id}`); repeat the param to OR across groups. Scopes the whole day series to members of the matching group(s), re-aggregated from member-level activity — org-wide seat/invite fields and the adoption rates derived from them are null on scoped rows. `rbac_group_id` accepts the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each UTC day (time-of-usage attribution). At most 100 entries.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsActivitySummaryResponse>> BetaGetSummariesV1OrganizationsAnalyticsSummariesGetAsResponseAsync(
            global::System.DateTime startingDate,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}