
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Chat activity recorded while members had Chat and Cowork unified turned<br/>
    /// on.
    /// </summary>
    public sealed partial class BetaAnalyticsChatCoworkUnifiedChatMetrics
    {
        /// <summary>
        /// Same measure as `chat_metrics.connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectorsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_artifacts_created_count`, for activity recorded while members had Chat and Cowork unified turned on. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctArtifactsCreatedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_connectors_used_count")]
        public int? DistinctConnectorsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_conversation_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_conversation_count")]
        public int? DistinctConversationCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_files_uploaded_count`, for activity recorded while members had Chat and Cowork unified turned on. It counts uploaded files as well as files Claude created and images returned by Claude's tools, such as screenshots. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_files_uploaded_count")]
        public int? DistinctFilesUploadedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_projects_created_count`, for activity recorded while members had Chat and Cowork unified turned on. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_projects_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctProjectsCreatedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_projects_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_projects_used_count")]
        public int? DistinctProjectsUsedCount { get; set; }

        /// <summary>
        /// Always null: shared-artifact views are not currently measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_shared_artifacts_viewed_count")]
        public int? DistinctSharedArtifactsViewedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.distinct_skills_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_skills_used_count")]
        public int? DistinctSkillsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.message_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.shared_conversations_viewed_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_conversations_viewed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SharedConversationsViewedCount { get; set; }

        /// <summary>
        /// Same measure as `chat_metrics.thinking_message_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ThinkingMessageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsChatCoworkUnifiedChatMetrics" /> class.
        /// </summary>
        /// <param name="connectorsUsedCount">
        /// Same measure as `chat_metrics.connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="distinctArtifactsCreatedCount">
        /// Same measure as `chat_metrics.distinct_artifacts_created_count`, for activity recorded while members had Chat and Cowork unified turned on. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="distinctProjectsCreatedCount">
        /// Same measure as `chat_metrics.distinct_projects_created_count`, for activity recorded while members had Chat and Cowork unified turned on. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="messageCount">
        /// Same measure as `chat_metrics.message_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="sharedConversationsViewedCount">
        /// Same measure as `chat_metrics.shared_conversations_viewed_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="thinkingMessageCount">
        /// Same measure as `chat_metrics.thinking_message_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="distinctConnectorsUsedCount">
        /// Same measure as `chat_metrics.distinct_connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctConversationCount">
        /// Same measure as `chat_metrics.distinct_conversation_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctFilesUploadedCount">
        /// Same measure as `chat_metrics.distinct_files_uploaded_count`, for activity recorded while members had Chat and Cowork unified turned on. It counts uploaded files as well as files Claude created and images returned by Claude's tools, such as screenshots. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctProjectsUsedCount">
        /// Same measure as `chat_metrics.distinct_projects_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSharedArtifactsViewedCount">
        /// Always null: shared-artifact views are not currently measured.
        /// </param>
        /// <param name="distinctSkillsUsedCount">
        /// Same measure as `chat_metrics.distinct_skills_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsChatCoworkUnifiedChatMetrics(
            int connectorsUsedCount,
            int distinctArtifactsCreatedCount,
            int distinctProjectsCreatedCount,
            int messageCount,
            int sharedConversationsViewedCount,
            int thinkingMessageCount,
            int? distinctConnectorsUsedCount,
            int? distinctConversationCount,
            int? distinctFilesUploadedCount,
            int? distinctProjectsUsedCount,
            int? distinctSharedArtifactsViewedCount,
            int? distinctSkillsUsedCount)
        {
            this.ConnectorsUsedCount = connectorsUsedCount;
            this.DistinctArtifactsCreatedCount = distinctArtifactsCreatedCount;
            this.DistinctConnectorsUsedCount = distinctConnectorsUsedCount;
            this.DistinctConversationCount = distinctConversationCount;
            this.DistinctFilesUploadedCount = distinctFilesUploadedCount;
            this.DistinctProjectsCreatedCount = distinctProjectsCreatedCount;
            this.DistinctProjectsUsedCount = distinctProjectsUsedCount;
            this.DistinctSharedArtifactsViewedCount = distinctSharedArtifactsViewedCount;
            this.DistinctSkillsUsedCount = distinctSkillsUsedCount;
            this.MessageCount = messageCount;
            this.SharedConversationsViewedCount = sharedConversationsViewedCount;
            this.ThinkingMessageCount = thinkingMessageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsChatCoworkUnifiedChatMetrics" /> class.
        /// </summary>
        public BetaAnalyticsChatCoworkUnifiedChatMetrics()
        {
        }

    }
}