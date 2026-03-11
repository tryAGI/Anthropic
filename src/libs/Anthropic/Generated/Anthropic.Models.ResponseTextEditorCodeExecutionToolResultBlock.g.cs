
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTextEditorCodeExecutionToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Anthropic.AnyOf<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// Default Value: text_editor_code_execution_tool_result
        /// </summary>
        /// <default>"text_editor_code_execution_tool_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text_editor_code_execution_tool_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextEditorCodeExecutionToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock> content,
            string toolUseId,
            string type = "text_editor_code_execution_tool_result")
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        public ResponseTextEditorCodeExecutionToolResultBlock()
        {
        }
    }
}