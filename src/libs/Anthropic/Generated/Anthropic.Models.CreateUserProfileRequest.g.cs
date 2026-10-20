
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The settings for a new user profile.<br/>
    /// Each request creates a new profile, even when another profile already has the same values.<br/>
    /// Example: {"name":"Example User","external_user_details":{"reference_id":"user_12345","onboarded_at":"2024-11-02T08:15:00Z","account_status":"active","entity_type":"business","country":"US"},"metadata":{}}
    /// </summary>
    public sealed partial class CreateUserProfileRequest
    {
        /// <summary>
        /// Optional for all profiles. Real-world name of the entity this profile represents (company or individual); for a company the platform resells Claude access to (`access_type` `passthrough`), that company's name where known. Maximum 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How the platform uses the API for this entity. `application` (default): the profile represents an individual end-user of the platform's product. `passthrough`: the profile identifies a company the platform resells Claude access to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileAccessTypeJsonConverter))]
        public global::Anthropic.UserProfileAccessType? AccessType { get; set; }

        /// <summary>
        /// Details about the entity this profile represents, as the platform states them. Every field is optional. Not accepted under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers, which take the top-level `external_id` (and, under `user-profiles-2026-08-18`, `external_user_onboarded_at`) instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_details")]
        public global::Anthropic.UserProfileExternalUserDetailsParams? ExternalUserDetails { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateUserProfileRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional for all profiles. Real-world name of the entity this profile represents (company or individual); for a company the platform resells Claude access to (`access_type` `passthrough`), that company's name where known. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// How the platform uses the API for this entity. `application` (default): the profile represents an individual end-user of the platform's product. `passthrough`: the profile identifies a company the platform resells Claude access to.
        /// </param>
        /// <param name="externalUserDetails">
        /// Details about the entity this profile represents, as the platform states them. Every field is optional. Not accepted under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers, which take the top-level `external_id` (and, under `user-profiles-2026-08-18`, `external_user_onboarded_at`) instead.
        /// </param>
        /// <param name="metadata">
        /// Free-form key-value data to attach to this user profile. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters. Values must be non-empty strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUserProfileRequest(
            string? name,
            global::Anthropic.UserProfileAccessType? accessType,
            global::Anthropic.UserProfileExternalUserDetailsParams? externalUserDetails,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserDetails = externalUserDetails;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserProfileRequest" /> class.
        /// </summary>
        public CreateUserProfileRequest()
        {
        }

    }
}