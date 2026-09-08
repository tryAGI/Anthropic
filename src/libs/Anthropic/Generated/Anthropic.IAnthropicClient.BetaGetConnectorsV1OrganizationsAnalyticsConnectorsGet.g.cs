#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Connector Usage<br/>
        /// Get per-connector usage for a given day, with cursor-based pagination.<br/>
        /// Returns connector usage metrics for the organization, sorted by connector<br/>
        /// name. Connector names are normalized from their various sources — for<br/>
        /// example, "Atlassian MCP server" and "mcp-atlassian" both appear as<br/>
        /// "atlassian". Use `group_by[]` to break usage out per member, per RBAC<br/>
        /// group, or per product surface, and `filter[]` to scope results; the<br/>
        /// parameter descriptions list the supported dimensions. Available to<br/>
        /// organizations on a Claude Enterprise plan. Requires an API key with the<br/>
        /// `read:analytics` scope.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get connector usage for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of a date range (inclusive). Enables rollup mode: one row per entity aggregated over the whole range — addable counters are summed across days, and a distinct count is never summed where summing could double-count (a field's range value is recomputed exactly over the window, approximate via HLL with typical error under 2%, null, or — for the creation-event counts, whose per-day values cannot overlap — a per-day sum that is itself exact; each field's own description says which). Use either `date` or `starting_date`, not both. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive); only valid with `starting_date`. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day), so this can be at most today — which is also the default when omitted, resolved once when the first page is served and reused for the rest of the pagination sequence. At most 366 days after `starting_date`.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100).
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `product`, `rbac_group_id`, `user_id`. Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `connector_name`, `product`, `rbac_group_id`, `user_id`. Value forms: `connector_name` matches case-insensitively, a display name such as 'GitHub MCP' also matches its normalized stored form ('github'), and for rows whose `connector_name` is an opaque connector id the connector's display name (`connector_display_name`) also matches; `product` is one of `chat`, `claude_code`, `cowork`, or `office_agent`; `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
        /// </param>
        /// <param name="orderBy">
        /// Sort field. Restricted to the endpoint's sort column plus its rankable metrics (metrics default to descending; a few metrics rank in date-range mode only, per the endpoint's documented orderable set).
        /// </param>
        /// <param name="order">
        /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsConnectorsResponse> BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetAsync(
            global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Connector Usage<br/>
        /// Get per-connector usage for a given day, with cursor-based pagination.<br/>
        /// Returns connector usage metrics for the organization, sorted by connector<br/>
        /// name. Connector names are normalized from their various sources — for<br/>
        /// example, "Atlassian MCP server" and "mcp-atlassian" both appear as<br/>
        /// "atlassian". Use `group_by[]` to break usage out per member, per RBAC<br/>
        /// group, or per product surface, and `filter[]` to scope results; the<br/>
        /// parameter descriptions list the supported dimensions. Available to<br/>
        /// organizations on a Claude Enterprise plan. Requires an API key with the<br/>
        /// `read:analytics` scope.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get connector usage for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of a date range (inclusive). Enables rollup mode: one row per entity aggregated over the whole range — addable counters are summed across days, and a distinct count is never summed where summing could double-count (a field's range value is recomputed exactly over the window, approximate via HLL with typical error under 2%, null, or — for the creation-event counts, whose per-day values cannot overlap — a per-day sum that is itself exact; each field's own description says which). Use either `date` or `starting_date`, not both. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive); only valid with `starting_date`. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day), so this can be at most today — which is also the default when omitted, resolved once when the first page is served and reused for the rest of the pagination sequence. At most 366 days after `starting_date`.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100).
        /// </param>
        /// <param name="page">
        /// Opaque cursor from a previous response's `next_page` field.
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `product`, `rbac_group_id`, `user_id`. Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `connector_name`, `product`, `rbac_group_id`, `user_id`. Value forms: `connector_name` matches case-insensitively, a display name such as 'GitHub MCP' also matches its normalized stored form ('github'), and for rows whose `connector_name` is an opaque connector id the connector's display name (`connector_display_name`) also matches; `product` is one of `chat`, `claude_code`, `cowork`, or `office_agent`; `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
        /// </param>
        /// <param name="orderBy">
        /// Sort field. Restricted to the endpoint's sort column plus its rankable metrics (metrics default to descending; a few metrics rank in date-range mode only, per the endpoint's documented orderable set).
        /// </param>
        /// <param name="order">
        /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsConnectorsResponse>> BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetAsResponseAsync(
            global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaAnalyticsConnectorActivity&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get connector usage for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="startingDate">
        /// UTC date in YYYY-MM-DD format. Start of a date range (inclusive). Enables rollup mode: one row per entity aggregated over the whole range — addable counters are summed across days, and a distinct count is never summed where summing could double-count (a field's range value is recomputed exactly over the window, approximate via HLL with typical error under 2%, null, or — for the creation-event counts, whose per-day values cannot overlap — a per-day sum that is itself exact; each field's own description says which). Use either `date` or `starting_date`, not both. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
        /// </param>
        /// <param name="endingDate">
        /// UTC date in YYYY-MM-DD format. End of the date range (exclusive); only valid with `starting_date`. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day), so this can be at most today — which is also the default when omitted, resolved once when the first page is served and reused for the rest of the pagination sequence. At most 366 days after `starting_date`.
        /// </param>
        /// <param name="limit">
        /// Number of results per page (1-1000, default 100).
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `product`, `rbac_group_id`, `user_id`. Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `connector_name`, `product`, `rbac_group_id`, `user_id`. Value forms: `connector_name` matches case-insensitively, a display name such as 'GitHub MCP' also matches its normalized stored form ('github'), and for rows whose `connector_name` is an opaque connector id the connector's display name (`connector_display_name`) also matches; `product` is one of `chat`, `claude_code`, `cowork`, or `office_agent`; `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
        /// </param>
        /// <param name="orderBy">
        /// Sort field. Restricted to the endpoint's sort column plus its rankable metrics (metrics default to descending; a few metrics rank in date-range mode only, per the endpoint's documented orderable set).
        /// </param>
        /// <param name="order">
        /// Sort direction: `asc` or `desc`. Defaults to `asc` for the endpoint's sort column and to `desc` when `order_by` names a metric (a top-N ranking). Applies to `order_by`, or to the endpoint's default sort field when `order_by` is omitted.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsConnectorActivity> BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetAutoPagingAsync(
              global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetConnectorsV1OrganizationsAnalyticsConnectorsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}