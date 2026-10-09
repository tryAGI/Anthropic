
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A connector's use in Cowork sessions recorded while members had<br/>
    /// Chat and Cowork unified turned on.
    /// </summary>
    public sealed partial class BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics
    {
        /// <summary>
        /// Same measure as `cowork_metrics.distinct_session_connector_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_connector_used_count")]
        public int? DistinctSessionConnectorUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics" /> class.
        /// </summary>
        /// <param name="distinctSessionConnectorUsedCount">
        /// Same measure as `cowork_metrics.distinct_session_connector_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics(
            int? distinctSessionConnectorUsedCount)
        {
            this.DistinctSessionConnectorUsedCount = distinctSessionConnectorUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics" /> class.
        /// </summary>
        public BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics()
        {
        }

    }
}