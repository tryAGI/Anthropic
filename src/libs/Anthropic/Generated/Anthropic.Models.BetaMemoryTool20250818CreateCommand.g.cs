
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMemoryTool20250818CreateCommand
    {
        /// <summary>
        /// Command type identifier<br/>
        /// Default Value: create
        /// </summary>
        /// <default>global::Anthropic.BetaMemoryTool20250818CreateCommandCommand.Create</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818CreateCommandCommandJsonConverter))]
        public global::Anthropic.BetaMemoryTool20250818CreateCommandCommand Command { get; set; } = global::Anthropic.BetaMemoryTool20250818CreateCommandCommand.Create;

        /// <summary>
        /// Path where the file should be created<br/>
        /// Example: /memories/notes.txt
        /// </summary>
        /// <example>/memories/notes.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Content to write to the file<br/>
        /// Example: Meeting notes:<br/>
        /// - Discussed project timeline<br/>
        /// - Next steps defined
        /// </summary>
        /// <example>
        /// Meeting notes:<br/>
        /// - Discussed project timeline<br/>
        /// - Next steps defined
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818CreateCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Command type identifier<br/>
        /// Default Value: create
        /// </param>
        /// <param name="path">
        /// Path where the file should be created<br/>
        /// Example: /memories/notes.txt
        /// </param>
        /// <param name="fileText">
        /// Content to write to the file<br/>
        /// Example: Meeting notes:<br/>
        /// - Discussed project timeline<br/>
        /// - Next steps defined
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMemoryTool20250818CreateCommand(
            string path,
            string fileText,
            global::Anthropic.BetaMemoryTool20250818CreateCommandCommand command = global::Anthropic.BetaMemoryTool20250818CreateCommandCommand.Create)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.FileText = fileText ?? throw new global::System.ArgumentNullException(nameof(fileText));
            this.Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818CreateCommand" /> class.
        /// </summary>
        public BetaMemoryTool20250818CreateCommand()
        {
        }
    }
}