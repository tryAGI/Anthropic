
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Details about the entity this profile represents, as the platform states them. Anthropic does not verify them. Every field is present, `null` until the platform supplies a value.
    /// </summary>
    public sealed partial class BetaUserProfileExternalUserDetails
    {
        /// <summary>
        /// The platform's own reference for the entity. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// When the entity opened its account with the platform, as stated by the platform, in RFC 3339 format (UTC). `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarded_at")]
        public global::System.DateTime? OnboardedAt { get; set; }

        /// <summary>
        /// The status of the entity's account on the platform: `active`, `suspended` or `blocked`. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_status")]
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? AccountStatus { get; set; }

        /// <summary>
        /// What kind of entity the profile represents: `individual`, `business`, `non_profit` or `government`. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        public global::Anthropic.BetaUserProfileExternalUserEntityType? EntityType { get; set; }

        /// <summary>
        /// The country the platform associates with the entity, as an ISO 3166-1 alpha-2 code. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The platform-computed hash of the entity's name. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_hash")]
        public string? NameHash { get; set; }

        /// <summary>
        /// The platform-computed hash of the entity's email address. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_hash")]
        public string? EmailHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileExternalUserDetails" /> class.
        /// </summary>
        /// <param name="referenceId">
        /// The platform's own reference for the entity. `null` until the platform supplies one.
        /// </param>
        /// <param name="onboardedAt">
        /// When the entity opened its account with the platform, as stated by the platform, in RFC 3339 format (UTC). `null` until the platform supplies one.
        /// </param>
        /// <param name="accountStatus">
        /// The status of the entity's account on the platform: `active`, `suspended` or `blocked`. `null` until the platform supplies one.
        /// </param>
        /// <param name="entityType">
        /// What kind of entity the profile represents: `individual`, `business`, `non_profit` or `government`. `null` until the platform supplies one.
        /// </param>
        /// <param name="country">
        /// The country the platform associates with the entity, as an ISO 3166-1 alpha-2 code. `null` until the platform supplies one.
        /// </param>
        /// <param name="nameHash">
        /// The platform-computed hash of the entity's name. `null` until the platform supplies one.
        /// </param>
        /// <param name="emailHash">
        /// The platform-computed hash of the entity's email address. `null` until the platform supplies one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileExternalUserDetails(
            string? referenceId,
            global::System.DateTime? onboardedAt,
            global::Anthropic.BetaUserProfileExternalUserAccountStatus? accountStatus,
            global::Anthropic.BetaUserProfileExternalUserEntityType? entityType,
            string? country,
            string? nameHash,
            string? emailHash)
        {
            this.ReferenceId = referenceId;
            this.OnboardedAt = onboardedAt;
            this.AccountStatus = accountStatus;
            this.EntityType = entityType;
            this.Country = country;
            this.NameHash = nameHash;
            this.EmailHash = emailHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileExternalUserDetails" /> class.
        /// </summary>
        public BetaUserProfileExternalUserDetails()
        {
        }

    }
}