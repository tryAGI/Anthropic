
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextEditorCodeExecutionToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_tool_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionToolResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlockType Type { get; set; } = global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseTextEditorCodeExecutionToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock> content,
            string toolUseId,
            global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlockType type = global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlockType.TextEditorCodeExecutionToolResult)
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        public BetaResponseTextEditorCodeExecutionToolResultBlock()
        {
        }
    }
}