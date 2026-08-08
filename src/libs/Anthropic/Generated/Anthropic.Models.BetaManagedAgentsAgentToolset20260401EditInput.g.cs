
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Input payload for the `edit` tool. Performs a string<br/>
    /// replacement in the named file; by default `old_string` must<br/>
    /// occur exactly once.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401EditInput
    {
        /// <summary>
        /// Path of the file to edit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Substring to find and replace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldString { get; set; }

        /// <summary>
        /// Replacement text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewString { get; set; }

        /// <summary>
        /// When true, replace every occurrence of `old_string`<br/>
        /// instead of requiring a unique match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_all")]
        public bool? ReplaceAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401EditInput" /> class.
        /// </summary>
        /// <param name="filePath">
        /// Path of the file to edit.
        /// </param>
        /// <param name="oldString">
        /// Substring to find and replace.
        /// </param>
        /// <param name="newString">
        /// Replacement text.
        /// </param>
        /// <param name="replaceAll">
        /// When true, replace every occurrence of `old_string`<br/>
        /// instead of requiring a unique match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401EditInput(
            string filePath,
            string oldString,
            string newString,
            bool? replaceAll)
        {
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.OldString = oldString ?? throw new global::System.ArgumentNullException(nameof(oldString));
            this.NewString = newString ?? throw new global::System.ArgumentNullException(nameof(newString));
            this.ReplaceAll = replaceAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401EditInput" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401EditInput()
        {
        }

    }
}