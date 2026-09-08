
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsUsageUsersResponse
    {
        /// <summary>
        /// Rows for this page, ranked by `order_by` in the `order` direction. One row per user, or several per user when `group_by[]` or `bucket_width` breaks that user's usage or cost out across rows. Rows split out by `cost_type` or `token_type` (cost endpoint only) stay adjacent and are ranked as one unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem> Data { get; set; }

        /// <summary>
        /// RFC 3339 timestamp of the export this response was served from. Null when no export yet covers any part of the requested range, in which case `data` is empty. Data beyond this watermark is incomplete; for stable results, set `ending_at` to this value or earlier. Data is typically refreshed every 4 hours but not final until about 30 days after the usage date (late-arriving events, reconciliation adjustments).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_refreshed_at")]
        public global::System.DateTime? DataRefreshedAt { get; set; }

        /// <summary>
        /// Whether another page is available. When true, pass `next_page` as the `page` parameter to fetch it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor for the next page, or null when `has_more` is false. Pass it as the `page` parameter, keeping the other parameters unchanged. A cursor can expire after the underlying data refreshes; the request then returns HTTP 410 and pagination must restart from the first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// ID of the Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUsageUsersResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Rows for this page, ranked by `order_by` in the `order` direction. One row per user, or several per user when `group_by[]` or `bucket_width` breaks that user's usage or cost out across rows. Rows split out by `cost_type` or `token_type` (cost endpoint only) stay adjacent and are ranked as one unit.
        /// </param>
        /// <param name="hasMore">
        /// Whether another page is available. When true, pass `next_page` as the `page` parameter to fetch it.
        /// </param>
        /// <param name="organizationId">
        /// ID of the Organization.
        /// </param>
        /// <param name="dataRefreshedAt">
        /// RFC 3339 timestamp of the export this response was served from. Null when no export yet covers any part of the requested range, in which case `data` is empty. Data beyond this watermark is incomplete; for stable results, set `ending_at` to this value or earlier. Data is typically refreshed every 4 hours but not final until about 30 days after the usage date (late-arriving events, reconciliation adjustments).
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page, or null when `has_more` is false. Pass it as the `page` parameter, keeping the other parameters unchanged. A cursor can expire after the underlying data refreshes; the request then returns HTTP 410 and pagination must restart from the first page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsUsageUsersResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageUsersItem> data,
            bool hasMore,
            string organizationId,
            global::System.DateTime? dataRefreshedAt,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.DataRefreshedAt = dataRefreshedAt;
            this.HasMore = hasMore;
            this.NextPage = nextPage;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUsageUsersResponse" /> class.
        /// </summary>
        public BetaAnalyticsUsageUsersResponse()
        {
        }

    }
}