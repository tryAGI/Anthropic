
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool defined by value: `definition` is a `tools` entry (any kind<br/>
    /// `tools` accepts, an MCP toolset included). An `mcp_toolset` given here<br/>
    /// also requires the `mcp-client-2026-09-15` beta.
    /// </summary>
    public sealed partial class BetaToolChangeToolDefinition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaToolUnionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaToolUnion Definition { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"tool_definition"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_definition";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChangeToolDefinition" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolChangeToolDefinition(
            global::Anthropic.BetaToolUnion definition,
            string type = "tool_definition")
        {
            this.Definition = definition;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChangeToolDefinition" /> class.
        /// </summary>
        public BetaToolChangeToolDefinition()
        {
        }

    }
}