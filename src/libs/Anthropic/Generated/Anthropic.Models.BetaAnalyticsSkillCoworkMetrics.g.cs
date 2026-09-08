
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cowork activity metrics for a single skill on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsSkillCoworkMetrics
    {
        /// <summary>
        /// Number of distinct Cowork sessions in which the skill was used. A skill counts as used only when it is explicitly activated — the model (or the user, via the skill's slash command) invokes it, reading its instructions into context as part of that activation. Skills that are merely installed or listed as available, or whose content reaches the context without an activation (preloaded, hook-injected, or read as a plain file), are not counted. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_skill_used_count")]
        public int? DistinctSessionSkillUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillCoworkMetrics" /> class.
        /// </summary>
        /// <param name="distinctSessionSkillUsedCount">
        /// Number of distinct Cowork sessions in which the skill was used. A skill counts as used only when it is explicitly activated — the model (or the user, via the skill's slash command) invokes it, reading its instructions into context as part of that activation. Skills that are merely installed or listed as available, or whose content reaches the context without an activation (preloaded, hook-injected, or read as a plain file), are not counted. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsSkillCoworkMetrics(
            int? distinctSessionSkillUsedCount)
        {
            this.DistinctSessionSkillUsedCount = distinctSessionSkillUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillCoworkMetrics" /> class.
        /// </summary>
        public BetaAnalyticsSkillCoworkMetrics()
        {
        }

    }
}