
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMemoryTool20250818StrReplaceCommand
    {
        /// <summary>
        /// Command type identifier<br/>
        /// Default Value: str_replace
        /// </summary>
        /// <default>global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand.StrReplace</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaMemoryTool20250818StrReplaceCommandCommandJsonConverter))]
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand Command { get; set; } = global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand.StrReplace;

        /// <summary>
        /// Path to the file where text should be replaced<br/>
        /// Example: /memories/preferences.txt
        /// </summary>
        /// <example>/memories/preferences.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Text to search for and replace<br/>
        /// Example: Favorite color: blue
        /// </summary>
        /// <example>Favorite color: blue</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_str")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldStr { get; set; }

        /// <summary>
        /// Text to replace with<br/>
        /// Example: Favorite color: green
        /// </summary>
        /// <example>Favorite color: green</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_str")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewStr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818StrReplaceCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Command type identifier<br/>
        /// Default Value: str_replace
        /// </param>
        /// <param name="path">
        /// Path to the file where text should be replaced<br/>
        /// Example: /memories/preferences.txt
        /// </param>
        /// <param name="oldStr">
        /// Text to search for and replace<br/>
        /// Example: Favorite color: blue
        /// </param>
        /// <param name="newStr">
        /// Text to replace with<br/>
        /// Example: Favorite color: green
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMemoryTool20250818StrReplaceCommand(
            string path,
            string oldStr,
            string newStr,
            global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand command = global::Anthropic.BetaMemoryTool20250818StrReplaceCommandCommand.StrReplace)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.OldStr = oldStr ?? throw new global::System.ArgumentNullException(nameof(oldStr));
            this.NewStr = newStr ?? throw new global::System.ArgumentNullException(nameof(newStr));
            this.Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMemoryTool20250818StrReplaceCommand" /> class.
        /// </summary>
        public BetaMemoryTool20250818StrReplaceCommand()
        {
        }
    }
}