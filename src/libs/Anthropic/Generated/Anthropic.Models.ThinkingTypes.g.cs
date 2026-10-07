
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which `thinking.type` values the model accepts on requests. Read each key on its own: for example, `enabled` can be false while `disabled` is true.
    /// </summary>
    public sealed partial class ThinkingTypes
    {
        /// <summary>
        /// Whether the model accepts thinking with type 'adaptive' (the model decides whether and how much to think).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.CapabilitySupport Adaptive { get; set; }

        /// <summary>
        /// Whether the model accepts thinking with type 'disabled' (thinking turned off). False exactly when a request that sends it gets a 400 from this model. True on a model that does not support thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.CapabilitySupport Disabled { get; set; }

        /// <summary>
        /// Whether the model accepts thinking with type 'enabled' (extended thinking with a caller-set `budget_tokens`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.CapabilitySupport Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingTypes" /> class.
        /// </summary>
        /// <param name="adaptive">
        /// Whether the model accepts thinking with type 'adaptive' (the model decides whether and how much to think).
        /// </param>
        /// <param name="disabled">
        /// Whether the model accepts thinking with type 'disabled' (thinking turned off). False exactly when a request that sends it gets a 400 from this model. True on a model that does not support thinking.
        /// </param>
        /// <param name="enabled">
        /// Whether the model accepts thinking with type 'enabled' (extended thinking with a caller-set `budget_tokens`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingTypes(
            global::Anthropic.CapabilitySupport adaptive,
            global::Anthropic.CapabilitySupport disabled,
            global::Anthropic.CapabilitySupport enabled)
        {
            this.Adaptive = adaptive ?? throw new global::System.ArgumentNullException(nameof(adaptive));
            this.Disabled = disabled ?? throw new global::System.ArgumentNullException(nameof(disabled));
            this.Enabled = enabled ?? throw new global::System.ArgumentNullException(nameof(enabled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingTypes" /> class.
        /// </summary>
        public ThinkingTypes()
        {
        }

    }
}