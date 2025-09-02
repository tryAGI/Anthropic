
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestTextEditorCodeExecutionStrReplaceResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<string>? Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_lines")]
        public int? NewLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_start")]
        public int? NewStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_lines")]
        public int? OldLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_start")]
        public int? OldStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionStrReplaceResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextEditorCodeExecutionStrReplaceResultBlock" /> class.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="newLines"></param>
        /// <param name="newStart"></param>
        /// <param name="oldLines"></param>
        /// <param name="oldStart"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestTextEditorCodeExecutionStrReplaceResultBlock(
            global::System.Collections.Generic.IList<string>? lines,
            int? newLines,
            int? newStart,
            int? oldLines,
            int? oldStart,
            global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType type)
        {
            this.Lines = lines;
            this.NewLines = newLines;
            this.NewStart = newStart;
            this.OldLines = oldLines;
            this.OldStart = oldStart;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextEditorCodeExecutionStrReplaceResultBlock" /> class.
        /// </summary>
        public BetaRequestTextEditorCodeExecutionStrReplaceResultBlock()
        {
        }
    }
}