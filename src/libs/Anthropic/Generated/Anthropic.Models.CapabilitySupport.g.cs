
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Indicates whether a capability is supported.
    /// </summary>
    public sealed partial class CapabilitySupport
    {
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
        /// Initializes a new instance of the <see cref="CapabilitySupport" /> class.
        /// </summary>
        /// <param name="supported">
        /// Whether this capability is supported by the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapabilitySupport(
            bool supported)
        {
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitySupport" /> class.
        /// </summary>
        public CapabilitySupport()
        {
        }
    }
}