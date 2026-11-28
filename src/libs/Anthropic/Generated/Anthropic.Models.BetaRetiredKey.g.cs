
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A key that a region has retired. Keep the key usable until `expires_at`.
    /// </summary>
    public sealed partial class BetaRetiredKey
    {
        /// <summary>
        /// When this entry is removed, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The ID of the retired External Key (`ekey_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalKeyId { get; set; }

        /// <summary>
        /// The code of the region that retired the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRetiredKey" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// When this entry is removed, in RFC 3339 format.
        /// </param>
        /// <param name="externalKeyId">
        /// The ID of the retired External Key (`ekey_...`).
        /// </param>
        /// <param name="region">
        /// The code of the region that retired the key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRetiredKey(
            global::System.DateTime expiresAt,
            string externalKeyId,
            string region)
        {
            this.ExpiresAt = expiresAt;
            this.ExternalKeyId = externalKeyId ?? throw new global::System.ArgumentNullException(nameof(externalKeyId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRetiredKey" /> class.
        /// </summary>
        public BetaRetiredKey()
        {
        }

    }
}