
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No key is set for this region.
    /// </summary>
    public sealed partial class BetaCmekRegionNotConfigured
    {
        /// <summary>
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_external_key_id")]
        public string? EffectiveExternalKeyId { get; set; }

        /// <summary>
        /// Default Value: not_configured
        /// </summary>
        /// <default>"not_configured"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_configured";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionNotConfigured" /> class.
        /// </summary>
        /// <param name="effectiveExternalKeyId">
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </param>
        /// <param name="type">
        /// Default Value: not_configured
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekRegionNotConfigured(
            string? effectiveExternalKeyId,
            string type = "not_configured")
        {
            this.EffectiveExternalKeyId = effectiveExternalKeyId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionNotConfigured" /> class.
        /// </summary>
        public BetaCmekRegionNotConfigured()
        {
        }

    }
}