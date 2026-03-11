
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMemoryTool20250818InsertCommand
    {
        /// <summary>
        /// Command type identifier<br/>
        /// Default Value: insert
        /// </summary>
        /// <default>global::Anthropic.BetaMemoryTool20250818InsertCommandCommand.Insert</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818InsertCommandCommandJsonConverter))]
        public global::Anthropic.BetaMemoryTool20250818InsertCommandCommand Command { get; set; } = global::Anthropic.BetaMemoryTool20250818InsertCommandCommand.Insert;

        /// <summary>
        /// Path to the file where text should be inserted<br/>
        /// Example: /memories/todo.txt
        /// </summary>
        /// <example>/memories/todo.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Line number where text should be inserted<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int InsertLine { get; set; } = default!;

        /// <summary>
        /// Text to insert at the specified line<br/>
        /// Example: - Review memory tool documentation
        /// </summary>
        /// <example>- Review memory tool documentation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("insert_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string InsertText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818InsertCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Command type identifier<br/>
        /// Default Value: insert
        /// </param>
        /// <param name="path">
        /// Path to the file where text should be inserted<br/>
        /// Example: /memories/todo.txt
        /// </param>
        /// <param name="insertLine">
        /// Line number where text should be inserted<br/>
        /// Example: 2
        /// </param>
        /// <param name="insertText">
        /// Text to insert at the specified line<br/>
        /// Example: - Review memory tool documentation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMemoryTool20250818InsertCommand(
            string path,
            int insertLine,
            string insertText,
            global::Anthropic.BetaMemoryTool20250818InsertCommandCommand command = global::Anthropic.BetaMemoryTool20250818InsertCommandCommand.Insert)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.InsertLine = insertLine;
            this.InsertText = insertText ?? throw new global::System.ArgumentNullException(nameof(insertText));
            this.Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818InsertCommand" /> class.
        /// </summary>
        public BetaMemoryTool20250818InsertCommand()
        {
        }
    }
}