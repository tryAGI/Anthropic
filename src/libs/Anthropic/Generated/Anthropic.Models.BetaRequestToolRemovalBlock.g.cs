
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Mid-conversation directive to withdraw a tool.<br/>
    /// ``tool`` references a tool (or MCP toolset) by name from the request's<br/>
    /// ``tools``; it is no longer offered to the model from this point in the<br/>
    /// conversation onward.
    /// </summary>
    public sealed partial class BetaRequestToolRemovalBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant132? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Tool2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Tool2 Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool_removal"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_removal";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolRemovalBlock" /> class.
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestToolRemovalBlock(
            global::Anthropic.Tool2 tool,
            global::Anthropic.CacheControlVariant132? cacheControl,
            string type = "tool_removal")
        {
            this.CacheControl = cacheControl;
            this.Tool = tool;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolRemovalBlock" /> class.
        /// </summary>
        public BetaRequestToolRemovalBlock()
        {
        }

    }
}