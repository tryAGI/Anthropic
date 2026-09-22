
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An entry of a `compaction` block's `tool_changes`: a tool of the<br/>
    /// request's `tools` (or an MCP tool or toolset) that the compacted range<br/>
    /// withdrew. Send it back unchanged.
    /// </summary>
    public sealed partial class BetaResponseToolRemovalBlock
    {
        /// <summary>
        /// A reference to the withdrawn `tools` entry, MCP tool or MCP toolset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Tool4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Tool4 Tool { get; set; }

        /// <summary>
        /// Default Value: tool_removal
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
        /// Initializes a new instance of the <see cref="BetaResponseToolRemovalBlock" /> class.
        /// </summary>
        /// <param name="tool">
        /// A reference to the withdrawn `tools` entry, MCP tool or MCP toolset.
        /// </param>
        /// <param name="type">
        /// Default Value: tool_removal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolRemovalBlock(
            global::Anthropic.Tool4 tool,
            string type = "tool_removal")
        {
            this.Tool = tool;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolRemovalBlock" /> class.
        /// </summary>
        public BetaResponseToolRemovalBlock()
        {
        }

    }
}