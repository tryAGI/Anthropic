
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude Design activity metrics for a single user on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsDesignMetrics
    {
        /// <summary>
        /// Number of distinct Claude Design projects created. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_projects_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctProjectsCreatedCount { get; set; }

        /// <summary>
        /// Number of distinct Claude Design projects the user worked in. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_projects_used_count")]
        public int? DistinctProjectsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct Claude Design sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_count")]
        public int? DistinctSessionCount { get; set; }

        /// <summary>
        /// Number of messages sent in Claude Design sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsDesignMetrics" /> class.
        /// </summary>
        /// <param name="distinctProjectsCreatedCount">
        /// Number of distinct Claude Design projects created. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="messageCount">
        /// Number of messages sent in Claude Design sessions
        /// </param>
        /// <param name="distinctProjectsUsedCount">
        /// Number of distinct Claude Design projects the user worked in. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSessionCount">
        /// Number of distinct Claude Design sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsDesignMetrics(
            int distinctProjectsCreatedCount,
            int messageCount,
            int? distinctProjectsUsedCount,
            int? distinctSessionCount)
        {
            this.DistinctProjectsCreatedCount = distinctProjectsCreatedCount;
            this.DistinctProjectsUsedCount = distinctProjectsUsedCount;
            this.DistinctSessionCount = distinctSessionCount;
            this.MessageCount = messageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsDesignMetrics" /> class.
        /// </summary>
        public BetaAnalyticsDesignMetrics()
        {
        }

    }
}