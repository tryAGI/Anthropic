
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A connector's use in chat conversations recorded while members had<br/>
    /// Chat and Cowork unified turned on.
    /// </summary>
    public sealed partial class BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics
    {
        /// <summary>
        /// Same measure as `chat_metrics.distinct_conversation_connector_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_conversation_connector_used_count")]
        public int? DistinctConversationConnectorUsedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics" /> class.
        /// </summary>
        /// <param name="distinctConversationConnectorUsedCount">
        /// Same measure as `chat_metrics.distinct_conversation_connector_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics(
            int? distinctConversationConnectorUsedCount)
        {
            this.DistinctConversationConnectorUsedCount = distinctConversationConnectorUsedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics" /> class.
        /// </summary>
        public BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics()
        {
        }

    }
}