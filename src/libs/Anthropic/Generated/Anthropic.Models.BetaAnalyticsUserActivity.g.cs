
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-user activity data for a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsUserActivity
    {
        /// <summary>
        /// Claude.ai activity metrics for a single user on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsChatMetrics ChatMetrics { get; set; }

        /// <summary>
        /// Claude Code activity metrics for a single user on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude_code_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsClaudeCodeMetrics ClaudeCodeMetrics { get; set; }

        /// <summary>
        /// Cowork activity metrics for a single user on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cowork_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsCoworkMetrics CoworkMetrics { get; set; }

        /// <summary>
        /// Claude Design activity metrics for a single user on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsDesignMetrics DesignMetrics { get; set; }

        /// <summary>
        /// Number of distinct active users represented by this row. Only set for grouped rollups (`group_by[]`); null for per-user rows. In date-range mode, recomputed as an exact distinct count of the group's active members over the requested window, never a sum of per-day values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_user_count")]
        public int? DistinctUserCount { get; set; }

        /// <summary>
        /// Most recent UTC day (YYYY-MM-DD) on which the user had any counted activity, within the requested window: equal to the requested `date` in single-day mode, and to the latest active day from `starting_date` (inclusive) to `ending_date` (exclusive) in date-range rollup mode — never a day earlier than the window start. On filtered requests (`filter[]`) only days matching the filter count: with `filter[]=rbac_group_id:{id}` it is the last day the user was active while a member of that group, consistent with the row's other metrics. On grouped (`group_by[]`) rows it is the latest day any member of the group was active (the requested `date` in single-day mode). Omitted from the response while last-activity reporting is not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity_date")]
        public global::System.DateTime? LastActivityDate { get; set; }

        /// <summary>
        /// Office Agent activity metrics for a single user on a given day, broken out by Office product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("office_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsOfficeMetrics OfficeMetrics { get; set; }

        /// <summary>
        /// Tagged RBAC group identifier (`rbac_group_...`), matching the spend-limits API spelling. Present only when the request grouped by `rbac_group_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        public string? RbacGroupId { get; set; }

        /// <summary>
        /// Resolved RBAC group display name, alongside `rbac_group_id` when name resolution is available. Null if the group has been deleted or its name could not be resolved; `rbac_group_id` remains the stable key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_name")]
        public string? RbacGroupName { get; set; }

        /// <summary>
        /// Claude Science activity metrics for a single user on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("science_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsScienceMetrics ScienceMetrics { get; set; }

        /// <summary>
        /// The user this row describes. Null on rows aggregated across users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Anthropic.BetaAnalyticsUser? User { get; set; }

        /// <summary>
        /// Number of web searches performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebSearchCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUserActivity" /> class.
        /// </summary>
        /// <param name="chatMetrics">
        /// Claude.ai activity metrics for a single user on a given day.
        /// </param>
        /// <param name="claudeCodeMetrics">
        /// Claude Code activity metrics for a single user on a given day.
        /// </param>
        /// <param name="coworkMetrics">
        /// Cowork activity metrics for a single user on a given day.
        /// </param>
        /// <param name="designMetrics">
        /// Claude Design activity metrics for a single user on a given day.
        /// </param>
        /// <param name="officeMetrics">
        /// Office Agent activity metrics for a single user on a given day, broken out by Office product.
        /// </param>
        /// <param name="scienceMetrics">
        /// Claude Science activity metrics for a single user on a given day.
        /// </param>
        /// <param name="webSearchCount">
        /// Number of web searches performed
        /// </param>
        /// <param name="distinctUserCount">
        /// Number of distinct active users represented by this row. Only set for grouped rollups (`group_by[]`); null for per-user rows. In date-range mode, recomputed as an exact distinct count of the group's active members over the requested window, never a sum of per-day values.
        /// </param>
        /// <param name="lastActivityDate">
        /// Most recent UTC day (YYYY-MM-DD) on which the user had any counted activity, within the requested window: equal to the requested `date` in single-day mode, and to the latest active day from `starting_date` (inclusive) to `ending_date` (exclusive) in date-range rollup mode — never a day earlier than the window start. On filtered requests (`filter[]`) only days matching the filter count: with `filter[]=rbac_group_id:{id}` it is the last day the user was active while a member of that group, consistent with the row's other metrics. On grouped (`group_by[]`) rows it is the latest day any member of the group was active (the requested `date` in single-day mode). Omitted from the response while last-activity reporting is not enabled for this organization.
        /// </param>
        /// <param name="rbacGroupId">
        /// Tagged RBAC group identifier (`rbac_group_...`), matching the spend-limits API spelling. Present only when the request grouped by `rbac_group_id`.
        /// </param>
        /// <param name="rbacGroupName">
        /// Resolved RBAC group display name, alongside `rbac_group_id` when name resolution is available. Null if the group has been deleted or its name could not be resolved; `rbac_group_id` remains the stable key.
        /// </param>
        /// <param name="user">
        /// The user this row describes. Null on rows aggregated across users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsUserActivity(
            global::Anthropic.BetaAnalyticsChatMetrics chatMetrics,
            global::Anthropic.BetaAnalyticsClaudeCodeMetrics claudeCodeMetrics,
            global::Anthropic.BetaAnalyticsCoworkMetrics coworkMetrics,
            global::Anthropic.BetaAnalyticsDesignMetrics designMetrics,
            global::Anthropic.BetaAnalyticsOfficeMetrics officeMetrics,
            global::Anthropic.BetaAnalyticsScienceMetrics scienceMetrics,
            int webSearchCount,
            int? distinctUserCount,
            global::System.DateTime? lastActivityDate,
            string? rbacGroupId,
            string? rbacGroupName,
            global::Anthropic.BetaAnalyticsUser? user)
        {
            this.ChatMetrics = chatMetrics ?? throw new global::System.ArgumentNullException(nameof(chatMetrics));
            this.ClaudeCodeMetrics = claudeCodeMetrics ?? throw new global::System.ArgumentNullException(nameof(claudeCodeMetrics));
            this.CoworkMetrics = coworkMetrics ?? throw new global::System.ArgumentNullException(nameof(coworkMetrics));
            this.DesignMetrics = designMetrics ?? throw new global::System.ArgumentNullException(nameof(designMetrics));
            this.DistinctUserCount = distinctUserCount;
            this.LastActivityDate = lastActivityDate;
            this.OfficeMetrics = officeMetrics ?? throw new global::System.ArgumentNullException(nameof(officeMetrics));
            this.RbacGroupId = rbacGroupId;
            this.RbacGroupName = rbacGroupName;
            this.ScienceMetrics = scienceMetrics ?? throw new global::System.ArgumentNullException(nameof(scienceMetrics));
            this.User = user;
            this.WebSearchCount = webSearchCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUserActivity" /> class.
        /// </summary>
        public BetaAnalyticsUserActivity()
        {
        }

    }
}