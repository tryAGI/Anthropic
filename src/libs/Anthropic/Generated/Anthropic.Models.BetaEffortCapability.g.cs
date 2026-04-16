
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Effort (reasoning_effort) capability details.
    /// </summary>
    public sealed partial class BetaEffortCapability
    {
        /// <summary>
        /// Whether the model supports high effort level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport High { get; set; }

        /// <summary>
        /// Whether the model supports low effort level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Low { get; set; }

        /// <summary>
        /// Whether the model supports max effort level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Max { get; set; }

        /// <summary>
        /// Whether the model supports medium effort level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Medium { get; set; }

        /// <summary>
        /// Whether this capability is supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Whether the model supports xhigh effort level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xhigh")]
        public global::Anthropic.BetaCapabilitySupport? Xhigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEffortCapability" /> class.
        /// </summary>
        /// <param name="high">
        /// Whether the model supports high effort level.
        /// </param>
        /// <param name="low">
        /// Whether the model supports low effort level.
        /// </param>
        /// <param name="max">
        /// Whether the model supports max effort level.
        /// </param>
        /// <param name="medium">
        /// Whether the model supports medium effort level.
        /// </param>
        /// <param name="supported">
        /// Whether this capability is supported by the model.
        /// </param>
        /// <param name="xhigh">
        /// Whether the model supports xhigh effort level.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEffortCapability(
            global::Anthropic.BetaCapabilitySupport high,
            global::Anthropic.BetaCapabilitySupport low,
            global::Anthropic.BetaCapabilitySupport max,
            global::Anthropic.BetaCapabilitySupport medium,
            bool supported,
            global::Anthropic.BetaCapabilitySupport? xhigh)
        {
            this.High = high ?? throw new global::System.ArgumentNullException(nameof(high));
            this.Low = low ?? throw new global::System.ArgumentNullException(nameof(low));
            this.Max = max ?? throw new global::System.ArgumentNullException(nameof(max));
            this.Medium = medium ?? throw new global::System.ArgumentNullException(nameof(medium));
            this.Supported = supported;
            this.Xhigh = xhigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEffortCapability" /> class.
        /// </summary>
        public BetaEffortCapability()
        {
        }
    }
}