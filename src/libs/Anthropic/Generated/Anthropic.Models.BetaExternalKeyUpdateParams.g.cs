
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Partial update — omitted fields are unchanged.<br/>
    /// `display_name` is always editable. `geo` and `provider_config`<br/>
    /// cannot be changed once any workspace references this config.
    /// </summary>
    public sealed partial class BetaExternalKeyUpdateParams
    {
        /// <summary>
        /// Human-friendly display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Data residency geo. Only `us` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo")]
        public string? Geo { get; set; }

        /// <summary>
        /// KMS provider identity and auth coordinates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_config")]
        public global::Anthropic.ProviderConfigVariant1? ProviderConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyUpdateParams" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Human-friendly display name.
        /// </param>
        /// <param name="geo">
        /// Data residency geo. Only `us` is supported.
        /// </param>
        /// <param name="providerConfig">
        /// KMS provider identity and auth coordinates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalKeyUpdateParams(
            string? displayName,
            string? geo,
            global::Anthropic.ProviderConfigVariant1? providerConfig)
        {
            this.DisplayName = displayName;
            this.Geo = geo;
            this.ProviderConfig = providerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyUpdateParams" /> class.
        /// </summary>
        public BetaExternalKeyUpdateParams()
        {
        }

    }
}