
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude.ai activity metrics for a single user on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsChatMetrics
    {
        /// <summary>
        /// Number of MCP connector invocations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectorsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct artifacts created. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctArtifactsCreatedCount { get; set; }

        /// <summary>
        /// Distinct claude.ai connectors this user used. Excludes calls whose connector could not be identified and all calls from organizations with zero data retention. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_connectors_used_count")]
        public int? DistinctConnectorsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct conversations the user participated in. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_conversation_count")]
        public int? DistinctConversationCount { get; set; }

        /// <summary>
        /// Number of distinct files uploaded. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_files_uploaded_count")]
        public int? DistinctFilesUploadedCount { get; set; }

        /// <summary>
        /// Number of distinct projects created. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_projects_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DistinctProjectsCreatedCount { get; set; }

        /// <summary>
        /// Number of distinct projects used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_projects_used_count")]
        public int? DistinctProjectsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct shared artifacts the user viewed. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_shared_artifacts_viewed_count")]
        public int? DistinctSharedArtifactsViewedCount { get; set; }

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
        /// Number of times the user opened a shared conversation in a project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_conversations_viewed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SharedConversationsViewedCount { get; set; }

        /// <summary>
        /// Number of messages that used extended thinking
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
        /// Initializes a new instance of the <see cref="BetaAnalyticsChatMetrics" /> class.
        /// </summary>
        /// <param name="connectorsUsedCount">
        /// Number of MCP connector invocations.
        /// </param>
        /// <param name="distinctArtifactsCreatedCount">
        /// Number of distinct artifacts created. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="distinctProjectsCreatedCount">
        /// Number of distinct projects created. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="messageCount">
        /// Number of messages sent
        /// </param>
        /// <param name="sharedConversationsViewedCount">
        /// Number of times the user opened a shared conversation in a project
        /// </param>
        /// <param name="thinkingMessageCount">
        /// Number of messages that used extended thinking
        /// </param>
        /// <param name="distinctConnectorsUsedCount">
        /// Distinct claude.ai connectors this user used. Excludes calls whose connector could not be identified and all calls from organizations with zero data retention. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctConversationCount">
        /// Number of distinct conversations the user participated in. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctFilesUploadedCount">
        /// Number of distinct files uploaded. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctProjectsUsedCount">
        /// Number of distinct projects used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSharedArtifactsViewedCount">
        /// Number of distinct shared artifacts the user viewed. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSkillsUsedCount">
        /// Number of distinct skills used. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsChatMetrics(
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
        /// Initializes a new instance of the <see cref="BetaAnalyticsChatMetrics" /> class.
        /// </summary>
        public BetaAnalyticsChatMetrics()
        {
        }

    }
}