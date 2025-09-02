
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestTextEditorCodeExecutionViewResultBlock
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionViewResultBlockFileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType FileType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionViewResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextEditorCodeExecutionViewResultBlock" /> class.
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
        public BetaRequestTextEditorCodeExecutionViewResultBlock(
            string content,
            global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockFileType fileType,
            int? numLines,
            int? startLine,
            int? totalLines,
            global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlockType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FileType = fileType;
            this.NumLines = numLines;
            this.StartLine = startLine;
            this.TotalLines = totalLines;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextEditorCodeExecutionViewResultBlock" /> class.
        /// </summary>
        public BetaRequestTextEditorCodeExecutionViewResultBlock()
        {
        }
    }
}