
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude Code activity metrics for a single plugin on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsPluginClaudeCodeMetrics
    {
        /// <summary>
        /// Number of distinct Claude Code sessions in which the plugin was invoked. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_plugin_used_count")]
        public int? DistinctSessionPluginUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginClaudeCodeMetrics" /> class.
        /// </summary>
        /// <param name="distinctSessionPluginUsedCount">
        /// Number of distinct Claude Code sessions in which the plugin was invoked. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsPluginClaudeCodeMetrics(
            int? distinctSessionPluginUsedCount)
        {
            this.DistinctSessionPluginUsedCount = distinctSessionPluginUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginClaudeCodeMetrics" /> class.
        /// </summary>
        public BetaAnalyticsPluginClaudeCodeMetrics()
        {
        }

    }
}