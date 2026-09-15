
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Compaction capability details: whether the model accepts the top-level<br/>
    /// `compaction` request parameter, with one entry per supported<br/>
    /// `compaction.type` value.
    /// </summary>
    public sealed partial class BetaCompactionCapability
    {
        /// <summary>
        /// Whether the summarize compaction type is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Summarize { get; set; }

        /// <summary>
        /// Whether this capability is supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionCapability" /> class.
        /// </summary>
        /// <param name="summarize">
        /// Whether the summarize compaction type is supported.
        /// </param>
        /// <param name="supported">
        /// Whether this capability is supported by the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionCapability(
            global::Anthropic.BetaCapabilitySupport summarize,
            bool supported)
        {
            this.Summarize = summarize ?? throw new global::System.ArgumentNullException(nameof(summarize));
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionCapability" /> class.
        /// </summary>
        public BetaCompactionCapability()
        {
        }

    }
}