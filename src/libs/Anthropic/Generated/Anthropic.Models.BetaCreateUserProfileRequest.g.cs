
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"external_id":"user_12345","external_user_onboarded_at":"2024-11-02T08:15:00Z","metadata":{}}
    /// </summary>
    public sealed partial class BetaCreateUserProfileRequest
    {
        /// <summary>
        /// Platform's own identifier for this user. Not enforced unique. Maximum 255 characters. Accepted under the `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers; under `user-profiles-2026-09-04` send `external_user_details.reference_id` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Optional for all profiles. Real-world name of the entity this profile represents (company or individual); for a company the platform resells Claude access to (`access_type` `passthrough`), that company's name where known. Maximum 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How the platform uses the API for this entity. `application` (default): the profile represents an individual end-user of the platform's product. `passthrough`: the profile identifies a company the platform resells Claude access to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUserProfileAccessTypeJsonConverter))]
        public global::Anthropic.BetaUserProfileAccessType? AccessType { get; set; }

        /// <summary>
        /// When the entity this profile represents opened its account with the platform, in RFC 3339 format: for an `application` profile, when the end-user signed up; for a `passthrough` profile, when the company became the platform's customer. Must be a complete timestamp no more than 1 minute in the future. Optional. Accepted under the `user-profiles-2026-08-18` beta header; under `user-profiles-2026-09-04` send `external_user_details.onboarded_at` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_onboarded_at")]
        public global::System.DateTime? ExternalUserOnboardedAt { get; set; }

        /// <summary>
        /// Details about the entity this profile represents, as the platform states them. Every field is optional. Accepted under the `user-profiles-2026-09-04` beta header only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_details")]
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? ExternalUserDetails { get; set; }

        /// <summary>
        /// Free-form key-value data to attach to this user profile. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters. Values must be non-empty strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateUserProfileRequest" /> class.
        /// </summary>
        /// <param name="externalId">
        /// Platform's own identifier for this user. Not enforced unique. Maximum 255 characters. Accepted under the `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers; under `user-profiles-2026-09-04` send `external_user_details.reference_id` instead.
        /// </param>
        /// <param name="name">
        /// Optional for all profiles. Real-world name of the entity this profile represents (company or individual); for a company the platform resells Claude access to (`access_type` `passthrough`), that company's name where known. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// How the platform uses the API for this entity. `application` (default): the profile represents an individual end-user of the platform's product. `passthrough`: the profile identifies a company the platform resells Claude access to.
        /// </param>
        /// <param name="externalUserOnboardedAt">
        /// When the entity this profile represents opened its account with the platform, in RFC 3339 format: for an `application` profile, when the end-user signed up; for a `passthrough` profile, when the company became the platform's customer. Must be a complete timestamp no more than 1 minute in the future. Optional. Accepted under the `user-profiles-2026-08-18` beta header; under `user-profiles-2026-09-04` send `external_user_details.onboarded_at` instead.
        /// </param>
        /// <param name="externalUserDetails">
        /// Details about the entity this profile represents, as the platform states them. Every field is optional. Accepted under the `user-profiles-2026-09-04` beta header only.
        /// </param>
        /// <param name="metadata">
        /// Free-form key-value data to attach to this user profile. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters. Values must be non-empty strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateUserProfileRequest(
            string? externalId,
            string? name,
            global::Anthropic.BetaUserProfileAccessType? accessType,
            global::System.DateTime? externalUserOnboardedAt,
            global::Anthropic.BetaUserProfileExternalUserDetailsParams? externalUserDetails,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.ExternalId = externalId;
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserOnboardedAt = externalUserOnboardedAt;
            this.ExternalUserDetails = externalUserDetails;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateUserProfileRequest" /> class.
        /// </summary>
        public BetaCreateUserProfileRequest()
        {
        }

    }
}