
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestTextEditorCodeExecutionToolResultBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestTextEditorCodeExecutionToolResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextEditorCodeExecutionToolResultBlock" /> class.
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
        public BetaRequestTextEditorCodeExecutionToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock> content,
            string toolUseId,
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlockType type)
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextEditorCodeExecutionToolResultBlock" /> class.
        /// </summary>
        public BetaRequestTextEditorCodeExecutionToolResultBlock()
        {
        }
    }
}