
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMemoryTool20250818ViewCommand
    {
        /// <summary>
        /// Command type identifier<br/>
        /// Default Value: view
        /// </summary>
        /// <default>global::Anthropic.BetaMemoryTool20250818ViewCommandCommand.View</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818ViewCommandCommandJsonConverter))]
        public global::Anthropic.BetaMemoryTool20250818ViewCommandCommand Command { get; set; } = global::Anthropic.BetaMemoryTool20250818ViewCommandCommand.View;

        /// <summary>
        /// Path to directory or file to view<br/>
        /// Example: /memories
        /// </summary>
        /// <example>/memories</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Optional line range for viewing specific lines<br/>
        /// Example: [1, 10]
        /// </summary>
        /// <example>[1, 10]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_range")]
        public global::System.Collections.Generic.IList<int>? ViewRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818ViewCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Command type identifier<br/>
        /// Default Value: view
        /// </param>
        /// <param name="path">
        /// Path to directory or file to view<br/>
        /// Example: /memories
        /// </param>
        /// <param name="viewRange">
        /// Optional line range for viewing specific lines<br/>
        /// Example: [1, 10]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMemoryTool20250818ViewCommand(
            string path,
            global::System.Collections.Generic.IList<int>? viewRange,
            global::Anthropic.BetaMemoryTool20250818ViewCommandCommand command = global::Anthropic.BetaMemoryTool20250818ViewCommandCommand.View)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Command = command;
            this.ViewRange = viewRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818ViewCommand" /> class.
        /// </summary>
        public BetaMemoryTool20250818ViewCommand()
        {
        }
    }
}