
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-tool accepted/rejected counts for Claude Code file modification tools.
    /// </summary>
    public sealed partial class BetaAnalyticsToolActions
    {
        /// <summary>
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsToolActionCounts EditTool { get; set; }

        /// <summary>
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_edit_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsToolActionCounts MultiEditTool { get; set; }

        /// <summary>
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notebook_edit_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsToolActionCounts NotebookEditTool { get; set; }

        /// <summary>
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsToolActionCounts WriteTool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsToolActions" /> class.
        /// </summary>
        /// <param name="editTool">
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </param>
        /// <param name="multiEditTool">
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </param>
        /// <param name="notebookEditTool">
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </param>
        /// <param name="writeTool">
        /// Accepted/rejected counts for a single Claude Code tool type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsToolActions(
            global::Anthropic.BetaAnalyticsToolActionCounts editTool,
            global::Anthropic.BetaAnalyticsToolActionCounts multiEditTool,
            global::Anthropic.BetaAnalyticsToolActionCounts notebookEditTool,
            global::Anthropic.BetaAnalyticsToolActionCounts writeTool)
        {
            this.EditTool = editTool ?? throw new global::System.ArgumentNullException(nameof(editTool));
            this.MultiEditTool = multiEditTool ?? throw new global::System.ArgumentNullException(nameof(multiEditTool));
            this.NotebookEditTool = notebookEditTool ?? throw new global::System.ArgumentNullException(nameof(notebookEditTool));
            this.WriteTool = writeTool ?? throw new global::System.ArgumentNullException(nameof(writeTool));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsToolActions" /> class.
        /// </summary>
        public BetaAnalyticsToolActions()
        {
        }

    }
}