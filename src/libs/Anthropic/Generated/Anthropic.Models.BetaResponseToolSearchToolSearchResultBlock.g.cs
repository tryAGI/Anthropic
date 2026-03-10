
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseToolSearchToolSearchResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock> ToolReferences { get; set; }

        /// <summary>
        /// Default Value: tool_search_tool_search_result
        /// </summary>
        /// <default>"tool_search_tool_search_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "tool_search_tool_search_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolSearchToolSearchResultBlock" /> class.
        /// </summary>
        /// <param name="toolReferences"></param>
        /// <param name="type">
        /// Default Value: tool_search_tool_search_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolSearchToolSearchResultBlock(
            global::System.Collections.Generic.IList<global::Anthropic.BetaResponseToolReferenceBlock> toolReferences,
            string type)
        {
            this.ToolReferences = toolReferences ?? throw new global::System.ArgumentNullException(nameof(toolReferences));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolSearchToolSearchResultBlock" /> class.
        /// </summary>
        public BetaResponseToolSearchToolSearchResultBlock()
        {
        }
    }
}