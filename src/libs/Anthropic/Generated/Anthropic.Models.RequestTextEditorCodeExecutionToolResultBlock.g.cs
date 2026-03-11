
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestTextEditorCodeExecutionToolResultBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant157? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="RequestTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestTextEditorCodeExecutionToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock> content,
            string toolUseId,
            global::Anthropic.CacheControlVariant157? cacheControl,
            string type = "text_editor_code_execution_tool_result")
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        public RequestTextEditorCodeExecutionToolResultBlock()
        {
        }
    }
}