
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextEditorCodeExecutionStrReplaceResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string>? Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? NewLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? NewStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OldLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OldStart { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_str_replace_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionStrReplaceResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType Type { get; set; } = global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionStrReplaceResultBlock" /> class.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="newLines"></param>
        /// <param name="newStart"></param>
        /// <param name="oldLines"></param>
        /// <param name="oldStart"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_str_replace_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseTextEditorCodeExecutionStrReplaceResultBlock(
            global::System.Collections.Generic.IList<string>? lines,
            int? newLines,
            int? newStart,
            int? oldLines,
            int? oldStart,
            global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType type = global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult)
        {
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
            this.NewLines = newLines;
            this.NewStart = newStart;
            this.OldLines = oldLines;
            this.OldStart = oldStart;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionStrReplaceResultBlock" /> class.
        /// </summary>
        public BetaResponseTextEditorCodeExecutionStrReplaceResultBlock()
        {
        }
    }
}