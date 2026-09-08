
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Office Agent activity metrics for a single user on a given day within one Office product.
    /// </summary>
    public sealed partial class BetaAnalyticsOfficeProductMetrics
    {
        /// <summary>
        /// Number of MCP connector invocations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectorsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct MCP connectors used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_connectors_used_count")]
        public int? DistinctConnectorsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct Office Agent sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_count")]
        public int? DistinctSessionCount { get; set; }

        /// <summary>
        /// Number of distinct skills used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_skills_used_count")]
        public int? DistinctSkillsUsedCount { get; set; }

        /// <summary>
        /// Number of messages sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Number of skill invocations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkillsUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsOfficeProductMetrics" /> class.
        /// </summary>
        /// <param name="connectorsUsedCount">
        /// Number of MCP connector invocations
        /// </param>
        /// <param name="messageCount">
        /// Number of messages sent
        /// </param>
        /// <param name="skillsUsedCount">
        /// Number of skill invocations
        /// </param>
        /// <param name="distinctConnectorsUsedCount">
        /// Number of distinct MCP connectors used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSessionCount">
        /// Number of distinct Office Agent sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSkillsUsedCount">
        /// Number of distinct skills used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsOfficeProductMetrics(
            int connectorsUsedCount,
            int messageCount,
            int skillsUsedCount,
            int? distinctConnectorsUsedCount,
            int? distinctSessionCount,
            int? distinctSkillsUsedCount)
        {
            this.ConnectorsUsedCount = connectorsUsedCount;
            this.DistinctConnectorsUsedCount = distinctConnectorsUsedCount;
            this.DistinctSessionCount = distinctSessionCount;
            this.DistinctSkillsUsedCount = distinctSkillsUsedCount;
            this.MessageCount = messageCount;
            this.SkillsUsedCount = skillsUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsOfficeProductMetrics" /> class.
        /// </summary>
        public BetaAnalyticsOfficeProductMetrics()
        {
        }

    }
}