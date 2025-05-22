
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseCodeExecutionToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseCodeExecutionToolResultError, global::Anthropic.BetaResponseCodeExecutionResultBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.BetaResponseCodeExecutionToolResultError, global::Anthropic.BetaResponseCodeExecutionResultBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: code_execution_tool_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseCodeExecutionToolResultBlockType.CodeExecutionToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseCodeExecutionToolResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseCodeExecutionToolResultBlockType Type { get; set; } = global::Anthropic.BetaResponseCodeExecutionToolResultBlockType.CodeExecutionToolResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeExecutionToolResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: code_execution_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCodeExecutionToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.BetaResponseCodeExecutionToolResultError, global::Anthropic.BetaResponseCodeExecutionResultBlock> content,
            string toolUseId,
            global::Anthropic.BetaResponseCodeExecutionToolResultBlockType type = global::Anthropic.BetaResponseCodeExecutionToolResultBlockType.CodeExecutionToolResult)
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeExecutionToolResultBlock" /> class.
        /// </summary>
        public BetaResponseCodeExecutionToolResultBlock()
        {
        }
    }
}