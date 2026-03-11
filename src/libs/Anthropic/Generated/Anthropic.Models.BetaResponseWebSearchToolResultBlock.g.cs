
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseWebSearchToolResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Caller8JsonConverter))]
        public global::Anthropic.Caller8? Caller { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: web_search_tool_result
        /// </summary>
        /// <default>"web_search_tool_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search_tool_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebSearchToolResultBlock" /> class.
        /// </summary>
        /// <param name="caller"></param>
        /// <param name="content"></param>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: web_search_tool_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseWebSearchToolResultBlock(
            global::Anthropic.AnyOf<global::Anthropic.BetaResponseWebSearchToolResultError, global::System.Collections.Generic.IList<global::Anthropic.BetaResponseWebSearchResultBlock>> content,
            string toolUseId,
            global::Anthropic.Caller8? caller,
            string type = "web_search_tool_result")
        {
            this.Content = content;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Caller = caller;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebSearchToolResultBlock" /> class.
        /// </summary>
        public BetaResponseWebSearchToolResultBlock()
        {
        }
    }
}