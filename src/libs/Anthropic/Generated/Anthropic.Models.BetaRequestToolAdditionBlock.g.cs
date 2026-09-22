
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Mid-conversation directive to make a tool available.<br/>
    /// ``tool`` is a reference to a tool (or MCP toolset) declared in the<br/>
    /// request's ``tools``. Under the ``inline-tools-2026-09-15`` beta it may<br/>
    /// instead be a reference to a tool defined earlier in ``messages``, or a<br/>
    /// ``tool_definition`` object that carries an inline tool definition in<br/>
    /// ``definition`` (the same object a ``tools`` entry holds). An ``mcp_toolset``<br/>
    /// definition also requires the ``mcp-client-2026-09-15`` beta. The tool is<br/>
    /// offered to the model from this point in the conversation onward.
    /// </summary>
    public sealed partial class BetaRequestToolAdditionBlock
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
            global::Anthropic.CacheControlVariant132? cacheControl,
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