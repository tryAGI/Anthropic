
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExternalKeyCreateParams
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ProviderConfig4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ProviderConfig4 ProviderConfig { get; set; }

        /// <summary>
        /// ID of a user profile to bind the key to. Omit this field for a key that isn't bound to a user profile. Such a key can be attached to a Workspace whatever its user profile. The binding cannot be changed later. A key bound to a user profile can only be attached to a Workspace that has the same user profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        public string? UserProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalKeyCreateParams" /> class.
        /// </summary>
        /// <param name="providerConfig">
        /// KMS provider identity and auth coordinates.
        /// </param>
        /// <param name="displayName">
        /// Human-friendly display name.
        /// </param>
        /// <param name="geo">
        /// Data residency geo. Only `us` is supported.
        /// </param>
        /// <param name="userProfileId">
        /// ID of a user profile to bind the key to. Omit this field for a key that isn't bound to a user profile. Such a key can be attached to a Workspace whatever its user profile. The binding cannot be changed later. A key bound to a user profile can only be attached to a Workspace that has the same user profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalKeyCreateParams(
            global::Anthropic.ProviderConfig4 providerConfig,
            string? displayName,
            string? geo,
            string? userProfileId)
        {
            this.DisplayName = displayName;
            this.Geo = geo;
            this.ProviderConfig = providerConfig;
            this.UserProfileId = userProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalKeyCreateParams" /> class.
        /// </summary>
        public ExternalKeyCreateParams()
        {
        }

    }
}