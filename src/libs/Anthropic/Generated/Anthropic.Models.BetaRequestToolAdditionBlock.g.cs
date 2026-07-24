
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Mid-conversation directive to surface a declared tool.<br/>
    /// ``tool`` references a tool (or MCP toolset) by name from the request's<br/>
    /// ``tools``; it is offered to the model from this point in the<br/>
    /// conversation onward.
    /// </summary>
    public sealed partial class BetaRequestToolAdditionBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant130? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Tool Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool_addition"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_addition";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolAdditionBlock" /> class.
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestToolAdditionBlock(
            global::Anthropic.Tool tool,
            global::Anthropic.CacheControlVariant130? cacheControl,
            string type = "tool_addition")
        {
            this.CacheControl = cacheControl;
            this.Tool = tool;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolAdditionBlock" /> class.
        /// </summary>
        public BetaRequestToolAdditionBlock()
        {
        }

    }
}