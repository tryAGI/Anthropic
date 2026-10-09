
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A skill's use in Cowork sessions recorded while members had Chat<br/>
    /// and Cowork unified turned on.
    /// </summary>
    public sealed partial class BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics
    {
        /// <summary>
        /// Same measure as `cowork_metrics.distinct_session_skill_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_skill_used_count")]
        public int? DistinctSessionSkillUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics" /> class.
        /// </summary>
        /// <param name="distinctSessionSkillUsedCount">
        /// Same measure as `cowork_metrics.distinct_session_skill_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics(
            int? distinctSessionSkillUsedCount)
        {
            this.DistinctSessionSkillUsedCount = distinctSessionSkillUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics" /> class.
        /// </summary>
        public BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics()
        {
        }

    }
}