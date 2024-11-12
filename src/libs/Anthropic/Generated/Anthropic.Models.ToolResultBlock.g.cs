
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The result of using a tool.
    /// </summary>
    public sealed partial class ToolResultBlock
    {
        /// <summary>
        /// The `id` of the tool use request this is a result for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// The result of the tool, as a string (e.g. `"content": "15 degrees"`) <br/>
        /// or list of nested content blocks (e.g. `"content": [{"type": "text", "text": "15 degrees"}]`). <br/>
        /// These content blocks can use the text or image types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.OneOf<string, global::System.Collections.Generic.IList<global::Anthropic.Block>> Content { get; set; }

        /// <summary>
        /// Set to `true` if the tool execution resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: tool_result
        /// </summary>
        /// <default>global::Anthropic.ToolResultBlockType.ToolResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolResultBlockTypeJsonConverter))]
        public global::Anthropic.ToolResultBlockType Type { get; set; } = global::Anthropic.ToolResultBlockType.ToolResult;

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultBlock" /> class.
        /// </summary>
        /// <param name="toolUseId">
        /// The `id` of the tool use request this is a result for.
        /// </param>
        /// <param name="content">
        /// The result of the tool, as a string (e.g. `"content": "15 degrees"`) <br/>
        /// or list of nested content blocks (e.g. `"content": [{"type": "text", "text": "15 degrees"}]`). <br/>
        /// These content blocks can use the text or image types.
        /// </param>
        /// <param name="isError">
        /// Set to `true` if the tool execution resulted in an error.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: tool_result
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolResultBlock(
            string toolUseId,
            global::Anthropic.OneOf<string, global::System.Collections.Generic.IList<global::Anthropic.Block>> content,
            bool? isError,
            global::Anthropic.CacheControlEphemeral? cacheControl,
            global::Anthropic.ToolResultBlockType type = global::Anthropic.ToolResultBlockType.ToolResult)
        {
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
            this.IsError = isError;
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultBlock" /> class.
        /// </summary>
        public ToolResultBlock()
        {
        }
    }
}