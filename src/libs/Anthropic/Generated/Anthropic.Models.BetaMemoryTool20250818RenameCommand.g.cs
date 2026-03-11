
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMemoryTool20250818RenameCommand
    {
        /// <summary>
        /// Command type identifier<br/>
        /// Default Value: rename
        /// </summary>
        /// <default>global::Anthropic.BetaMemoryTool20250818RenameCommandCommand.Rename</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818RenameCommandCommandJsonConverter))]
        public global::Anthropic.BetaMemoryTool20250818RenameCommandCommand Command { get; set; } = global::Anthropic.BetaMemoryTool20250818RenameCommandCommand.Rename;

        /// <summary>
        /// Current path of the file or directory<br/>
        /// Example: /memories/draft.txt
        /// </summary>
        /// <example>/memories/draft.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldPath { get; set; }

        /// <summary>
        /// New path for the file or directory<br/>
        /// Example: /memories/final.txt
        /// </summary>
        /// <example>/memories/final.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818RenameCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Command type identifier<br/>
        /// Default Value: rename
        /// </param>
        /// <param name="oldPath">
        /// Current path of the file or directory<br/>
        /// Example: /memories/draft.txt
        /// </param>
        /// <param name="newPath">
        /// New path for the file or directory<br/>
        /// Example: /memories/final.txt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMemoryTool20250818RenameCommand(
            string oldPath,
            string newPath,
            global::Anthropic.BetaMemoryTool20250818RenameCommandCommand command = global::Anthropic.BetaMemoryTool20250818RenameCommandCommand.Rename)
        {
            this.OldPath = oldPath ?? throw new global::System.ArgumentNullException(nameof(oldPath));
            this.NewPath = newPath ?? throw new global::System.ArgumentNullException(nameof(newPath));
            this.Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818RenameCommand" /> class.
        /// </summary>
        public BetaMemoryTool20250818RenameCommand()
        {
        }
    }
}