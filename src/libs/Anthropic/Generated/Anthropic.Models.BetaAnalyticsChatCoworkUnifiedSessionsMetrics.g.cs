
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cowork session activity recorded while members had Chat and Cowork<br/>
    /// unified turned on.
    /// </summary>
    public sealed partial class BetaAnalyticsChatCoworkUnifiedSessionsMetrics
    {
        /// <summary>
        /// Same measure as `cowork_metrics.action_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActionCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.artifacts_created_count`, for activity recorded while members had Chat and Cowork unified turned on. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ArtifactsCreatedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectorsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.dispatch_turn_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatch_turn_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DispatchTurnCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.distinct_connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_connectors_used_count")]
        public int? DistinctConnectorsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.distinct_plugins_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_plugins_used_count")]
        public int? DistinctPluginsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.distinct_session_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_count")]
        public int? DistinctSessionCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.distinct_skills_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_skills_used_count")]
        public int? DistinctSkillsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.edit_tool_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_tool_count")]
        public int? EditToolCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.file_edit_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_edit_count")]
        public int? FileEditCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.message_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.multi_edit_tool_count`, for activity recorded while members had Chat and Cowork unified turned on. Claude no longer has a multi-edit tool, so expect 0 when not null; each edit is now a separate Edit tool call, counted in `edit_tool_count` and `file_edit_count`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_edit_tool_count")]
        public int? MultiEditToolCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.notebook_edit_tool_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notebook_edit_tool_count")]
        public int? NotebookEditToolCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.plugins_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins_used_count")]
        public int? PluginsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.sessions_with_file_edits_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_with_file_edits_count")]
        public int? SessionsWithFileEditsCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.skills_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkillsUsedCount { get; set; }

        /// <summary>
        /// Same measure as `cowork_metrics.write_tool_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_tool_count")]
        public int? WriteToolCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsChatCoworkUnifiedSessionsMetrics" /> class.
        /// </summary>
        /// <param name="actionCount">
        /// Same measure as `cowork_metrics.action_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="artifactsCreatedCount">
        /// Same measure as `cowork_metrics.artifacts_created_count`, for activity recorded while members had Chat and Cowork unified turned on. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="connectorsUsedCount">
        /// Same measure as `cowork_metrics.connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="dispatchTurnCount">
        /// Same measure as `cowork_metrics.dispatch_turn_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="messageCount">
        /// Same measure as `cowork_metrics.message_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="skillsUsedCount">
        /// Same measure as `cowork_metrics.skills_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="distinctConnectorsUsedCount">
        /// Same measure as `cowork_metrics.distinct_connectors_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctPluginsUsedCount">
        /// Same measure as `cowork_metrics.distinct_plugins_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSessionCount">
        /// Same measure as `cowork_metrics.distinct_session_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSkillsUsedCount">
        /// Same measure as `cowork_metrics.distinct_skills_used_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="editToolCount">
        /// Same measure as `cowork_metrics.edit_tool_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="fileEditCount">
        /// Same measure as `cowork_metrics.file_edit_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="multiEditToolCount">
        /// Same measure as `cowork_metrics.multi_edit_tool_count`, for activity recorded while members had Chat and Cowork unified turned on. Claude no longer has a multi-edit tool, so expect 0 when not null; each edit is now a separate Edit tool call, counted in `edit_tool_count` and `file_edit_count`.
        /// </param>
        /// <param name="notebookEditToolCount">
        /// Same measure as `cowork_metrics.notebook_edit_tool_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="pluginsUsedCount">
        /// Same measure as `cowork_metrics.plugins_used_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
        /// <param name="sessionsWithFileEditsCount">
        /// Same measure as `cowork_metrics.sessions_with_file_edits_count`, for activity recorded while members had Chat and Cowork unified turned on. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="writeToolCount">
        /// Same measure as `cowork_metrics.write_tool_count`, for activity recorded while members had Chat and Cowork unified turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsChatCoworkUnifiedSessionsMetrics(
            int actionCount,
            int artifactsCreatedCount,
            int connectorsUsedCount,
            int dispatchTurnCount,
            int messageCount,
            int skillsUsedCount,
            int? distinctConnectorsUsedCount,
            int? distinctPluginsUsedCount,
            int? distinctSessionCount,
            int? distinctSkillsUsedCount,
            int? editToolCount,
            int? fileEditCount,
            int? multiEditToolCount,
            int? notebookEditToolCount,
            int? pluginsUsedCount,
            int? sessionsWithFileEditsCount,
            int? writeToolCount)
        {
            this.ActionCount = actionCount;
            this.ArtifactsCreatedCount = artifactsCreatedCount;
            this.ConnectorsUsedCount = connectorsUsedCount;
            this.DispatchTurnCount = dispatchTurnCount;
            this.DistinctConnectorsUsedCount = distinctConnectorsUsedCount;
            this.DistinctPluginsUsedCount = distinctPluginsUsedCount;
            this.DistinctSessionCount = distinctSessionCount;
            this.DistinctSkillsUsedCount = distinctSkillsUsedCount;
            this.EditToolCount = editToolCount;
            this.FileEditCount = fileEditCount;
            this.MessageCount = messageCount;
            this.MultiEditToolCount = multiEditToolCount;
            this.NotebookEditToolCount = notebookEditToolCount;
            this.PluginsUsedCount = pluginsUsedCount;
            this.SessionsWithFileEditsCount = sessionsWithFileEditsCount;
            this.SkillsUsedCount = skillsUsedCount;
            this.WriteToolCount = writeToolCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsChatCoworkUnifiedSessionsMetrics" /> class.
        /// </summary>
        public BetaAnalyticsChatCoworkUnifiedSessionsMetrics()
        {
        }

    }
}