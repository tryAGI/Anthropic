
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Supported thinking type configurations.
    /// </summary>
    public sealed partial class BetaThinkingTypes
    {
        /// <summary>
        /// Whether the model supports thinking with type 'adaptive' (auto).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Adaptive { get; set; }

        /// <summary>
        /// Whether the model supports thinking with type 'enabled'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingTypes" /> class.
        /// </summary>
        /// <param name="adaptive">
        /// Whether the model supports thinking with type 'adaptive' (auto).
        /// </param>
        /// <param name="enabled">
        /// Whether the model supports thinking with type 'enabled'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingTypes(
            global::Anthropic.BetaCapabilitySupport adaptive,
            global::Anthropic.BetaCapabilitySupport enabled)
        {
            this.Adaptive = adaptive ?? throw new global::System.ArgumentNullException(nameof(adaptive));
            this.Enabled = enabled ?? throw new global::System.ArgumentNullException(nameof(enabled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingTypes" /> class.
        /// </summary>
        public BetaThinkingTypes()
        {
        }
    }
}