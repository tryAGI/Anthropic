
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The region is validating the configured key, or the key has passed validation and the region has not started to apply it.
    /// </summary>
    public sealed partial class BetaCmekRegionPending
    {
        /// <summary>
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_external_key_id")]
        public string? EffectiveExternalKeyId { get; set; }

        /// <summary>
        /// Why the latest validation attempt failed. `null` when no attempt has failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Default Value: pending
        /// </summary>
        /// <default>"pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "pending";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionPending" /> class.
        /// </summary>
        /// <param name="effectiveExternalKeyId">
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </param>
        /// <param name="error">
        /// Why the latest validation attempt failed. `null` when no attempt has failed.
        /// </param>
        /// <param name="type">
        /// Default Value: pending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekRegionPending(
            string? effectiveExternalKeyId,
            string? error,
            string type = "pending")
        {
            this.EffectiveExternalKeyId = effectiveExternalKeyId;
            this.Error = error;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionPending" /> class.
        /// </summary>
        public BetaCmekRegionPending()
        {
        }

    }
}