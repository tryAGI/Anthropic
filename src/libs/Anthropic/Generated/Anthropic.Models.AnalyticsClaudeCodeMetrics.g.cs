
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude Code activity metrics for a single user on a given day.
    /// </summary>
    public sealed partial class AnalyticsClaudeCodeMetrics
    {
        /// <summary>
        /// Core Claude Code activity metrics for a single user on a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnalyticsCoreCodeMetrics CoreMetrics { get; set; }

        /// <summary>
        /// Per-tool accepted/rejected counts for Claude Code file modification tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnalyticsToolActions ToolActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClaudeCodeMetrics" /> class.
        /// </summary>
        /// <param name="coreMetrics">
        /// Core Claude Code activity metrics for a single user on a given day.
        /// </param>
        /// <param name="toolActions">
        /// Per-tool accepted/rejected counts for Claude Code file modification tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsClaudeCodeMetrics(
            global::Anthropic.AnalyticsCoreCodeMetrics coreMetrics,
            global::Anthropic.AnalyticsToolActions toolActions)
        {
            this.CoreMetrics = coreMetrics ?? throw new global::System.ArgumentNullException(nameof(coreMetrics));
            this.ToolActions = toolActions ?? throw new global::System.ArgumentNullException(nameof(toolActions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsClaudeCodeMetrics" /> class.
        /// </summary>
        public AnalyticsClaudeCodeMetrics()
        {
        }

    }
}