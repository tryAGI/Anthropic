
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMemoryTool20250818DeleteCommand
    {
        /// <summary>
        /// Command type identifier<br/>
        /// Default Value: delete
        /// </summary>
        /// <default>global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand.Delete</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818DeleteCommandCommandJsonConverter))]
        public global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand Command { get; set; } = global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand.Delete;

        /// <summary>
        /// Path to the file or directory to delete<br/>
        /// Example: /memories/old_file.txt
        /// </summary>
        /// <example>/memories/old_file.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818DeleteCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Command type identifier<br/>
        /// Default Value: delete
        /// </param>
        /// <param name="path">
        /// Path to the file or directory to delete<br/>
        /// Example: /memories/old_file.txt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMemoryTool20250818DeleteCommand(
            string path,
            global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand command = global::Anthropic.BetaMemoryTool20250818DeleteCommandCommand.Delete)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818DeleteCommand" /> class.
        /// </summary>
        public BetaMemoryTool20250818DeleteCommand()
        {
        }
    }
}