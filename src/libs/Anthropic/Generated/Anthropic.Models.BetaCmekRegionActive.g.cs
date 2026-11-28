
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The configured key passed validation, and the region applies it.
    /// </summary>
    public sealed partial class BetaCmekRegionActive
    {
        /// <summary>
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_external_key_id")]
        public string? EffectiveExternalKeyId { get; set; }

        /// <summary>
        /// Why Google Cloud KMS refused the region's latest use of the key. `null` when the region has no refusal to report. A `null` does not mean that the key works.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// When the region last got a successful answer from Google Cloud KMS for the key, in RFC 3339 format. `null` when it has none to report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_checked_at")]
        public global::System.DateTime? LastCheckedAt { get; set; }

        /// <summary>
        /// Default Value: active
        /// </summary>
        /// <default>"active"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "active";

        /// <summary>
        /// When the status last became `active`, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ValidatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionActive" /> class.
        /// </summary>
        /// <param name="validatedAt">
        /// When the status last became `active`, in RFC 3339 format.
        /// </param>
        /// <param name="effectiveExternalKeyId">
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </param>
        /// <param name="error">
        /// Why Google Cloud KMS refused the region's latest use of the key. `null` when the region has no refusal to report. A `null` does not mean that the key works.
        /// </param>
        /// <param name="lastCheckedAt">
        /// When the region last got a successful answer from Google Cloud KMS for the key, in RFC 3339 format. `null` when it has none to report.
        /// </param>
        /// <param name="type">
        /// Default Value: active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekRegionActive(
            global::System.DateTime validatedAt,
            string? effectiveExternalKeyId,
            string? error,
            global::System.DateTime? lastCheckedAt,
            string type = "active")
        {
            this.EffectiveExternalKeyId = effectiveExternalKeyId;
            this.Error = error;
            this.LastCheckedAt = lastCheckedAt;
            this.Type = type;
            this.ValidatedAt = validatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionActive" /> class.
        /// </summary>
        public BetaCmekRegionActive()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCmekRegionActive"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCmekRegionActive FromValidatedAt(global::System.DateTime validatedAt)
        {
            return new BetaCmekRegionActive
            {
                ValidatedAt = validatedAt,
            };
        }

    }
}