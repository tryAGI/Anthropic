
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestTextEditorCodeExecutionViewResultBlock
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.RequestTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lines")]
        public int? TotalLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"text_editor_code_execution_view_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text_editor_code_execution_view_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTextEditorCodeExecutionViewResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="fileType"></param>
        /// <param name="numLines"></param>
        /// <param name="startLine"></param>
        /// <param name="totalLines"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestTextEditorCodeExecutionViewResultBlock(
            string content,
            global::Anthropic.RequestTextEditorCodeExecutionViewResultBlockFileType fileType,
            int? numLines,
            int? startLine,
            int? totalLines,
            string type = "text_editor_code_execution_view_result")
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FileType = fileType;
            this.NumLines = numLines;
            this.StartLine = startLine;
            this.TotalLines = totalLines;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTextEditorCodeExecutionViewResultBlock" /> class.
        /// </summary>
        public RequestTextEditorCodeExecutionViewResultBlock()
        {
        }
    }
}