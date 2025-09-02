
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextEditorCodeExecutionViewResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? StartLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? TotalLines { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_view_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionViewResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockType Type { get; set; } = global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionViewResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="fileType"></param>
        /// <param name="numLines"></param>
        /// <param name="startLine"></param>
        /// <param name="totalLines"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_view_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseTextEditorCodeExecutionViewResultBlock(
            string content,
            global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockFileType fileType,
            int? numLines,
            int? startLine,
            int? totalLines,
            global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockType type = global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FileType = fileType;
            this.NumLines = numLines;
            this.StartLine = startLine;
            this.TotalLines = totalLines;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionViewResultBlock" /> class.
        /// </summary>
        public BetaResponseTextEditorCodeExecutionViewResultBlock()
        {
        }
    }
}