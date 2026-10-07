
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Web search and code execution tool support, with one entry per tool.
    /// </summary>
    public sealed partial class BetaServerToolsCapability
    {
        /// <summary>
        /// Whether the model supports the code execution tool: true when the model supports at least one version of the tool, not necessarily every version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_execution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport CodeExecution { get; set; }

        /// <summary>
        /// Whether this capability is supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Whether the model supports the web search tool: true when the model supports at least one version of the tool, not necessarily every version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolsCapability" /> class.
        /// </summary>
        /// <param name="codeExecution">
        /// Whether the model supports the code execution tool: true when the model supports at least one version of the tool, not necessarily every version.
        /// </param>
        /// <param name="supported">
        /// Whether this capability is supported by the model.
        /// </param>
        /// <param name="webSearch">
        /// Whether the model supports the web search tool: true when the model supports at least one version of the tool, not necessarily every version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaServerToolsCapability(
            global::Anthropic.BetaCapabilitySupport codeExecution,
            bool supported,
            global::Anthropic.BetaCapabilitySupport webSearch)
        {
            this.CodeExecution = codeExecution ?? throw new global::System.ArgumentNullException(nameof(codeExecution));
            this.Supported = supported;
            this.WebSearch = webSearch ?? throw new global::System.ArgumentNullException(nameof(webSearch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaServerToolsCapability" /> class.
        /// </summary>
        public BetaServerToolsCapability()
        {
        }

    }
}