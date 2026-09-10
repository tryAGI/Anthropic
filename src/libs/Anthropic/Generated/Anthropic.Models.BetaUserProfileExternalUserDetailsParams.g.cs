
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUserProfileExternalUserDetailsParams
    {
        /// <summary>
        /// The platform's own reference for the entity, for example the key of the end-user's row in the platform's database. Not interpreted by Anthropic and not enforced unique. 1 to 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// When the entity opened its account with the platform, in RFC 3339 format: for an `application` profile, when the end-user signed up; for a `passthrough` profile, when the company became the platform's customer. Must be a complete timestamp no more than 1 minute in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarded_at")]
        public global::System.DateTime? OnboardedAt { get; set; }

        /// <summary>
        /// The status of the entity's account on the platform: `active`, `suspended` or `blocked`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_status")]
        public global::Anthropic.BetaUserProfileExternalUserAccountStatus? AccountStatus { get; set; }

        /// <summary>
        /// What kind of entity the profile represents: `individual`, `business`, `non_profit` or `government`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        public global::Anthropic.BetaUserProfileExternalUserEntityType? EntityType { get; set; }

        /// <summary>
        /// The country of the entity (not of the platform), as the platform determines it: an ISO 3166-1 alpha-2 code in upper case, for example `US`. Only the form, two uppercase ASCII letters, is checked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// A hash of the entity's name, computed by the platform. Anthropic treats it as an opaque string and does not prescribe the hash function. 1 to 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_hash")]
        public string? NameHash { get; set; }

        /// <summary>
        /// A hash of the entity's email address, computed by the platform. Anthropic treats it as an opaque string and does not prescribe the hash function. 1 to 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_hash")]
        public string? EmailHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileExternalUserDetailsParams" /> class.
        /// </summary>
        /// <param name="referenceId">
        /// The platform's own reference for the entity, for example the key of the end-user's row in the platform's database. Not interpreted by Anthropic and not enforced unique. 1 to 255 characters.
        /// </param>
        /// <param name="onboardedAt">
        /// When the entity opened its account with the platform, in RFC 3339 format: for an `application` profile, when the end-user signed up; for a `passthrough` profile, when the company became the platform's customer. Must be a complete timestamp no more than 1 minute in the future.
        /// </param>
        /// <param name="accountStatus">
        /// The status of the entity's account on the platform: `active`, `suspended` or `blocked`.
        /// </param>
        /// <param name="entityType">
        /// What kind of entity the profile represents: `individual`, `business`, `non_profit` or `government`.
        /// </param>
        /// <param name="country">
        /// The country of the entity (not of the platform), as the platform determines it: an ISO 3166-1 alpha-2 code in upper case, for example `US`. Only the form, two uppercase ASCII letters, is checked.
        /// </param>
        /// <param name="nameHash">
        /// A hash of the entity's name, computed by the platform. Anthropic treats it as an opaque string and does not prescribe the hash function. 1 to 255 characters.
        /// </param>
        /// <param name="emailHash">
        /// A hash of the entity's email address, computed by the platform. Anthropic treats it as an opaque string and does not prescribe the hash function. 1 to 255 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileExternalUserDetailsParams(
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
        /// Initializes a new instance of the <see cref="BetaUserProfileExternalUserDetailsParams" /> class.
        /// </summary>
        public BetaUserProfileExternalUserDetailsParams()
        {
        }

    }
}