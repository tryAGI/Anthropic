#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Plugin Usage<br/>
        /// Get per-plugin install + invocation usage for a given day, with pagination.<br/>
        /// Returns plugin usage metrics for the organization across Cowork and Claude<br/>
        /// Code, sorted by plugin name. The `plugin_name` value `third-party` is<br/>
        /// an aggregate bucket, not a plugin: it collects plugin activity, from<br/>
        /// either surface, for which the reporting client did not provide a plugin<br/>
        /// name — so an organization's own plugins can contribute both to their own<br/>
        /// named rows and to this bucket. Use `group_by[]` to break usage out per<br/>
        /// member, per RBAC group, or per product surface (Cowork / Claude Code),<br/>
        /// and `filter[]` to scope results; the parameter descriptions list the<br/>
        /// supported dimensions. Requires an API key with the<br/>
        /// `read:analytics` scope. `starting_date` / `ending_date` select<br/>
        /// range-rollup mode like `/skills`.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get plugin usage for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
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
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `product`, `rbac_group_id`, `user_id`. On this endpoint `product` takes the values `claude_code` or `cowork` only (the surfaces with plugin attribution). Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `plugin_name`, `product`, `rbac_group_id`, `user_id`. Value forms: `plugin_name` matches case-insensitively; `product` is `claude_code` or `cowork` (the only surfaces with plugin attribution); `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaAnalyticsPluginsResponse> BetaGetPluginsV1OrganizationsAnalyticsPluginsGetAsync(
            global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Plugin Usage<br/>
        /// Get per-plugin install + invocation usage for a given day, with pagination.<br/>
        /// Returns plugin usage metrics for the organization across Cowork and Claude<br/>
        /// Code, sorted by plugin name. The `plugin_name` value `third-party` is<br/>
        /// an aggregate bucket, not a plugin: it collects plugin activity, from<br/>
        /// either surface, for which the reporting client did not provide a plugin<br/>
        /// name — so an organization's own plugins can contribute both to their own<br/>
        /// named rows and to this bucket. Use `group_by[]` to break usage out per<br/>
        /// member, per RBAC group, or per product surface (Cowork / Claude Code),<br/>
        /// and `filter[]` to scope results; the parameter descriptions list the<br/>
        /// supported dimensions. Requires an API key with the<br/>
        /// `read:analytics` scope. `starting_date` / `ending_date` select<br/>
        /// range-rollup mode like `/skills`.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get plugin usage for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
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
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `product`, `rbac_group_id`, `user_id`. On this endpoint `product` takes the values `claude_code` or `cowork` only (the surfaces with plugin attribution). Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `plugin_name`, `product`, `rbac_group_id`, `user_id`. Value forms: `plugin_name` matches case-insensitively; `product` is `claude_code` or `cowork` (the only surfaces with plugin attribution); `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaAnalyticsPluginsResponse>> BetaGetPluginsV1OrganizationsAnalyticsPluginsGetAsResponseAsync(
            global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            string? page = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetPluginsV1OrganizationsAnalyticsPluginsGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaAnalyticsPluginActivity&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="date">
        /// UTC date in YYYY-MM-DD format. The day to get plugin usage for. Data is typically available with a 1-day lag (varies by query; the error for a too-recent date names the latest available day) and may be revised by a few percent over the following days. No earlier than 2026-01-01.
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
        /// Dimensions to break results out by (e.g. `group_by[]=user_id`). Supported on this endpoint: `product`, `rbac_group_id`, `user_id`. On this endpoint `product` takes the values `claude_code` or `cowork` only (the surfaces with plugin attribution). Grouped rows carry the requested dimension values as additional fields and paginate like ungrouped responses via `next_page`; an unsupported dimension returns 400. `rbac_group_id` attributes a user to every group they held at any point during each covered UTC day, so grouped rows are not an exclusive partition and can sum above org-level totals. At most 100 entries.
        /// </param>
        /// <param name="filter">
        /// Filters as `dimension:value`, e.g. `filter[]=rbac_group_id:{id}`. Repeat the param for OR within a dimension and across dimensions for AND. Supported dimensions on this endpoint: `plugin_name`, `product`, `rbac_group_id`, `user_id`. Value forms: `plugin_name` matches case-insensitively; `product` is `claude_code` or `cowork` (the only surfaces with plugin attribution); `rbac_group_id` takes the tagged id (`rbac_group_...`, as emitted in responses and by the spend-limits API) or a bare group UUID, and matches users who held the group at any point during each covered UTC day (time-of-usage attribution); `user_id` takes a tagged user id (`user_...`), as emitted in responses. An unsupported dimension returns 400. At most 100 entries.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaAnalyticsPluginActivity> BetaGetPluginsV1OrganizationsAnalyticsPluginsGetAutoPagingAsync(
              global::System.DateTime? date = default,
            global::System.DateTime? startingDate = default,
            global::System.DateTime? endingDate = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<string>? filter = default,
            string? orderBy = default,
            global::Anthropic.BetaGetPluginsV1OrganizationsAnalyticsPluginsGetOrder? order = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}