
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Thinking capability details.
    /// </summary>
    public sealed partial class BetaThinkingCapability
    {
        /// <summary>
        /// Whether this capability is supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Supported thinking type configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaThinkingTypes Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingCapability" /> class.
        /// </summary>
        /// <param name="supported">
        /// Whether this capability is supported by the model.
        /// </param>
        /// <param name="types">
        /// Supported thinking type configurations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingCapability(
            bool supported,
            global::Anthropic.BetaThinkingTypes types)
        {
            this.Supported = supported;
            this.Types = types ?? throw new global::System.ArgumentNullException(nameof(types));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingCapability" /> class.
        /// </summary>
        public BetaThinkingCapability()
        {
        }
    }
}