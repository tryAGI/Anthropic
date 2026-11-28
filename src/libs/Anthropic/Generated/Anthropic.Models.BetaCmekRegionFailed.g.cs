
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The region stopped retrying validation before the configured key passed. To restart validation, send the region a key again. It can be the same key.
    /// </summary>
    public sealed partial class BetaCmekRegionFailed
    {
        /// <summary>
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_external_key_id")]
        public string? EffectiveExternalKeyId { get; set; }

        /// <summary>
        /// Why the region cannot use the configured key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Default Value: failed
        /// </summary>
        /// <default>"failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "failed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionFailed" /> class.
        /// </summary>
        /// <param name="error">
        /// Why the region cannot use the configured key.
        /// </param>
        /// <param name="effectiveExternalKeyId">
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </param>
        /// <param name="type">
        /// Default Value: failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekRegionFailed(
            string error,
            string? effectiveExternalKeyId,
            string type = "failed")
        {
            this.EffectiveExternalKeyId = effectiveExternalKeyId;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionFailed" /> class.
        /// </summary>
        public BetaCmekRegionFailed()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCmekRegionFailed"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCmekRegionFailed FromError(string error)
        {
            return new BetaCmekRegionFailed
            {
                Error = error,
            };
        }

    }
}