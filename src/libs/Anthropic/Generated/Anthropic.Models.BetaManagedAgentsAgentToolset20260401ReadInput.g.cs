
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Input payload for the `read` tool. Reads file contents<br/>
    /// relative to the runner's working directory (or absolute when<br/>
    /// the runner permits).
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401ReadInput
    {
        /// <summary>
        /// Path of the file to read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Optional `[start_line, end_line]` 1-indexed inclusive<br/>
        /// range. When omitted the entire file is returned.<br/>
        /// `end_line` of 0 or negative means "to end of file".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_range")]
        public global::System.Collections.Generic.IList<int>? ViewRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401ReadInput" /> class.
        /// </summary>
        /// <param name="filePath">
        /// Path of the file to read.
        /// </param>
        /// <param name="viewRange">
        /// Optional `[start_line, end_line]` 1-indexed inclusive<br/>
        /// range. When omitted the entire file is returned.<br/>
        /// `end_line` of 0 or negative means "to end of file".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401ReadInput(
            string filePath,
            global::System.Collections.Generic.IList<int>? viewRange)
        {
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.ViewRange = viewRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401ReadInput" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401ReadInput()
        {
        }

    }
}