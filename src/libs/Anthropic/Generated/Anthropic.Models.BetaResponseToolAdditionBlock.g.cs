
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An entry of a `compaction` block's `tool_changes`: a tool the<br/>
    /// compacted range made available, as a reference to a `tools` entry or<br/>
    /// MCP toolset, or as the tool definition in effect at the end of the<br/>
    /// range, by value. Send it back unchanged.
    /// </summary>
    public sealed partial class BetaResponseToolAdditionBlock
    {
        /// <summary>
        /// The tool made available: a reference to a `tools` entry or MCP toolset, or a `tool_definition` carrying the definition by value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Tool3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Tool3 Tool { get; set; }

        /// <summary>
        /// Default Value: tool_addition
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
        /// Initializes a new instance of the <see cref="BetaResponseToolAdditionBlock" /> class.
        /// </summary>
        /// <param name="tool">
        /// The tool made available: a reference to a `tools` entry or MCP toolset, or a `tool_definition` carrying the definition by value.
        /// </param>
        /// <param name="type">
        /// Default Value: tool_addition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolAdditionBlock(
            global::Anthropic.Tool3 tool,
            string type = "tool_addition")
        {
            this.Tool = tool;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolAdditionBlock" /> class.
        /// </summary>
        public BetaResponseToolAdditionBlock()
        {
        }

    }
}