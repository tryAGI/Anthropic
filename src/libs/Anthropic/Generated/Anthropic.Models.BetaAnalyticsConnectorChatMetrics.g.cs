
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude.ai activity metrics for a single connector on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsConnectorChatMetrics
    {
        /// <summary>
        /// Number of distinct conversations in which the connector was used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_conversation_connector_used_count")]
        public int? DistinctConversationConnectorUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatMetrics" /> class.
        /// </summary>
        /// <param name="distinctConversationConnectorUsedCount">
        /// Number of distinct conversations in which the connector was used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsConnectorChatMetrics(
            int? distinctConversationConnectorUsedCount)
        {
            this.DistinctConversationConnectorUsedCount = distinctConversationConnectorUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatMetrics" /> class.
        /// </summary>
        public BetaAnalyticsConnectorChatMetrics()
        {
        }

    }
}