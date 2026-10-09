
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A plugin's use in Cowork sessions recorded while members had Chat<br/>
    /// and Cowork unified turned on.
    /// </summary>
    public sealed partial class BetaAnalyticsPluginChatCoworkUnifiedMetrics
    {
        /// <summary>
        /// Same measure as `cowork_metrics.distinct_session_plugin_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_plugin_used_count")]
        public int? DistinctSessionPluginUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        /// <param name="distinctSessionPluginUsedCount">
        /// Same measure as `cowork_metrics.distinct_session_plugin_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsPluginChatCoworkUnifiedMetrics(
            int? distinctSessionPluginUsedCount)
        {
            this.DistinctSessionPluginUsedCount = distinctSessionPluginUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        public BetaAnalyticsPluginChatCoworkUnifiedMetrics()
        {
        }

    }
}