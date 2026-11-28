
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has withdrawn or paused its approval of customer-managed keys for this project, so the region does not apply the control.
    /// </summary>
    public sealed partial class BetaCmekRegionSuspended
    {
        /// <summary>
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_external_key_id")]
        public string? EffectiveExternalKeyId { get; set; }

        /// <summary>
        /// Default Value: suspended
        /// </summary>
        /// <default>"suspended"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "suspended";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionSuspended" /> class.
        /// </summary>
        /// <param name="effectiveExternalKeyId">
        /// The ID of the External Key that the region applies now (`ekey_...`). While a replacement key is `pending` or `failed`, this is the previous key. `null` when the region applies no key.
        /// </param>
        /// <param name="type">
        /// Default Value: suspended
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekRegionSuspended(
            string? effectiveExternalKeyId,
            string type = "suspended")
        {
            this.EffectiveExternalKeyId = effectiveExternalKeyId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekRegionSuspended" /> class.
        /// </summary>
        public BetaCmekRegionSuspended()
        {
        }

    }
}