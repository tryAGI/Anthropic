
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseMCPToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>> Content { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        /// <default>false</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsError { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: mcp_tool_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseMCPToolResultBlockType.McpToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseMCPToolResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseMCPToolResultBlockType Type { get; set; } = global::Anthropic.BetaResponseMCPToolResultBlockType.McpToolResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPToolResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="isError">
        /// Default Value: false
        /// </param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: mcp_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseMCPToolResultBlock(
            global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseTextBlock>> content,
            bool isError,
            string toolUseId,
            global::Anthropic.BetaResponseMCPToolResultBlockType type = global::Anthropic.BetaResponseMCPToolResultBlockType.McpToolResult)
        {
            this.Content = content;
            this.IsError = isError;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPToolResultBlock" /> class.
        /// </summary>
        public BetaResponseMCPToolResultBlock()
        {
        }
    }
}