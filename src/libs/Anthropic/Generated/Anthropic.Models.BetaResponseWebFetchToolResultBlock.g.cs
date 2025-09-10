
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseWebFetchToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: web_fetch_tool_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseWebFetchToolResultBlockType.WebFetchToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseWebFetchToolResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseWebFetchToolResultBlockType Type { get; set; } = global::Anthropic.BetaResponseWebFetchToolResultBlockType.WebFetchToolResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebFetchToolResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: web_fetch_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseWebFetchToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebFetchToolResultError, global::Anthropic.BetaResponseWebFetchResultBlock> content,
            string toolUseId,
            global::Anthropic.BetaResponseWebFetchToolResultBlockType type = global::Anthropic.BetaResponseWebFetchToolResultBlockType.WebFetchToolResult)
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebFetchToolResultBlock" /> class.
        /// </summary>
        public BetaResponseWebFetchToolResultBlock()
        {
        }
    }
}