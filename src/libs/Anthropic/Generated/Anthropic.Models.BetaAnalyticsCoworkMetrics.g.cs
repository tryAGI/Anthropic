
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cowork activity metrics for a single user on a given day.
    /// </summary>
    public sealed partial class BetaAnalyticsCoworkMetrics
    {
        /// <summary>
        /// Number of tool actions completed in Cowork sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActionCount { get; set; }

        /// <summary>
        /// Number of artifacts created in Cowork sessions: an artifact counts once, on the day a session first saves it. Counted from 2026-08-17; 0 on earlier days. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_created_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ArtifactsCreatedCount { get; set; }

        /// <summary>
        /// Total number of connector invocations in Cowork sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectorsUsedCount { get; set; }

        /// <summary>
        /// Number of Dispatch (background agent) turns completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatch_turn_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DispatchTurnCount { get; set; }

        /// <summary>
        /// Number of distinct connectors used in Cowork sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_connectors_used_count")]
        public int? DistinctConnectorsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct plugins used in Cowork sessions. Null while Cowork plugin-use metrics are not enabled for this organization. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_plugins_used_count")]
        public int? DistinctPluginsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct Cowork sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_session_count")]
        public int? DistinctSessionCount { get; set; }

        /// <summary>
        /// Number of distinct skills used in Cowork sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinct_skills_used_count")]
        public int? DistinctSkillsUsedCount { get; set; }

        /// <summary>
        /// Number of successful Edit tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_tool_count")]
        public int? EditToolCount { get; set; }

        /// <summary>
        /// Number of successful file-edit tool calls (Edit, MultiEdit, Write, NotebookEdit) in Cowork sessions. Null, never 0, while the file-edit metrics are not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_edit_count")]
        public int? FileEditCount { get; set; }

        /// <summary>
        /// Number of messages sent in Cowork sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageCount { get; set; }

        /// <summary>
        /// Number of successful MultiEdit tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_edit_tool_count")]
        public int? MultiEditToolCount { get; set; }

        /// <summary>
        /// Number of successful NotebookEdit tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notebook_edit_tool_count")]
        public int? NotebookEditToolCount { get; set; }

        /// <summary>
        /// Total number of plugin invocations in Cowork sessions. Null while Cowork plugin-use metrics are not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins_used_count")]
        public int? PluginsUsedCount { get; set; }

        /// <summary>
        /// Number of distinct Cowork sessions with at least one successful file-edit tool call. Null while the file-edit metrics are not enabled for this organization. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_with_file_edits_count")]
        public int? SessionsWithFileEditsCount { get; set; }

        /// <summary>
        /// Total number of skill invocations in Cowork sessions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills_used_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SkillsUsedCount { get; set; }

        /// <summary>
        /// Number of successful Write tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_tool_count")]
        public int? WriteToolCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsCoworkMetrics" /> class.
        /// </summary>
        /// <param name="actionCount">
        /// Number of tool actions completed in Cowork sessions
        /// </param>
        /// <param name="artifactsCreatedCount">
        /// Number of artifacts created in Cowork sessions: an artifact counts once, on the day a session first saves it. Counted from 2026-08-17; 0 on earlier days. Exact in date-range mode: a creation belongs to exactly one day, so the per-day counts never overlap and their sum over the window is the exact count of distinct creations in it.
        /// </param>
        /// <param name="connectorsUsedCount">
        /// Total number of connector invocations in Cowork sessions
        /// </param>
        /// <param name="dispatchTurnCount">
        /// Number of Dispatch (background agent) turns completed
        /// </param>
        /// <param name="messageCount">
        /// Number of messages sent in Cowork sessions
        /// </param>
        /// <param name="skillsUsedCount">
        /// Total number of skill invocations in Cowork sessions
        /// </param>
        /// <param name="distinctConnectorsUsedCount">
        /// Number of distinct connectors used in Cowork sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctPluginsUsedCount">
        /// Number of distinct plugins used in Cowork sessions. Null while Cowork plugin-use metrics are not enabled for this organization. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSessionCount">
        /// Number of distinct Cowork sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="distinctSkillsUsedCount">
        /// Number of distinct skills used in Cowork sessions. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="editToolCount">
        /// Number of successful Edit tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </param>
        /// <param name="fileEditCount">
        /// Number of successful file-edit tool calls (Edit, MultiEdit, Write, NotebookEdit) in Cowork sessions. Null, never 0, while the file-edit metrics are not enabled for this organization.
        /// </param>
        /// <param name="multiEditToolCount">
        /// Number of successful MultiEdit tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </param>
        /// <param name="notebookEditToolCount">
        /// Number of successful NotebookEdit tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </param>
        /// <param name="pluginsUsedCount">
        /// Total number of plugin invocations in Cowork sessions. Null while Cowork plugin-use metrics are not enabled for this organization.
        /// </param>
        /// <param name="sessionsWithFileEditsCount">
        /// Number of distinct Cowork sessions with at least one successful file-edit tool call. Null while the file-edit metrics are not enabled for this organization. Approximate (HLL, typical error &lt;2%) in date-range mode. Null on aggregated rows where a distinct count cannot be computed.
        /// </param>
        /// <param name="writeToolCount">
        /// Number of successful Write tool calls in Cowork sessions. Null while the file-edit metrics are not enabled for this organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsCoworkMetrics(
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
        /// Initializes a new instance of the <see cref="BetaAnalyticsCoworkMetrics" /> class.
        /// </summary>
        public BetaAnalyticsCoworkMetrics()
        {
        }

    }
}