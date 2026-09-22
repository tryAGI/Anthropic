
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool defined by value, as a `compaction` block's `tool_changes` entry<br/>
    /// reports it: `definition` is the tool's definition as it was sent, in the<br/>
    /// form of a `tools` entry, without `cache_control`. Send it back unchanged<br/>
    /// with the block.
    /// </summary>
    public sealed partial class BetaResponseToolChangeToolDefinition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseToolUnionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaResponseToolUnion Definition { get; set; }

        /// <summary>
        /// Default Value: tool_definition
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
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeToolDefinition" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="type">
        /// Default Value: tool_definition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolChangeToolDefinition(
            global::Anthropic.BetaResponseToolUnion definition,
            string type = "tool_definition")
        {
            this.Definition = definition;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolChangeToolDefinition" /> class.
        /// </summary>
        public BetaResponseToolChangeToolDefinition()
        {
        }

    }
}