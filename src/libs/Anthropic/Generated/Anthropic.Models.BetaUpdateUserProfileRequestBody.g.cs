
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"external_id":"user_12345"}
    /// </summary>
    public sealed partial class BetaUpdateUserProfileRequestBody
    {
        /// <summary>
        /// If present, replaces the stored external_id. Omit to leave unchanged. Maximum 255 characters. Accepted under the `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers; under `user-profiles-2026-09-04` send `external_user_details.reference_id` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Key-value pairs to merge into the stored metadata. Keys provided overwrite existing values. To remove a key, set its value to an empty string. Keys not provided are left unchanged. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// If present, replaces the stored name. Omit to leave unchanged. Maximum 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If present, replaces the stored access type. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_type")]
        public global::Anthropic.BetaUserProfileAccessType? AccessType { get; set; }

        /// <summary>
        /// If present, replaces the stored account creation time. Omit to leave unchanged; once set, the value cannot be cleared and `null` is rejected. Must be a complete RFC 3339 timestamp no more than 1 minute in the future. Accepted under the `user-profiles-2026-08-18` beta header; under `user-profiles-2026-09-04` send `external_user_details.onboarded_at` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_onboarded_at")]
        public global::System.DateTime? ExternalUserOnboardedAt { get; set; }

        /// <summary>
        /// Details about the entity this profile represents, as the platform states them. Each field sent replaces the stored value; omit a field to leave it unchanged. Once set, a value cannot be cleared and `null` is rejected. Accepted under the `user-profiles-2026-09-04` beta header only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_details")]
        public global::Anthropic.BetaUserProfileExternalUserDetailsParams? ExternalUserDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserProfileRequestBody" /> class.
        /// </summary>
        /// <param name="externalId">
        /// If present, replaces the stored external_id. Omit to leave unchanged. Maximum 255 characters. Accepted under the `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers; under `user-profiles-2026-09-04` send `external_user_details.reference_id` instead.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to merge into the stored metadata. Keys provided overwrite existing values. To remove a key, set its value to an empty string. Keys not provided are left unchanged. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters.
        /// </param>
        /// <param name="name">
        /// If present, replaces the stored name. Omit to leave unchanged. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// If present, replaces the stored access type. Omit to leave unchanged.
        /// </param>
        /// <param name="externalUserOnboardedAt">
        /// If present, replaces the stored account creation time. Omit to leave unchanged; once set, the value cannot be cleared and `null` is rejected. Must be a complete RFC 3339 timestamp no more than 1 minute in the future. Accepted under the `user-profiles-2026-08-18` beta header; under `user-profiles-2026-09-04` send `external_user_details.onboarded_at` instead.
        /// </param>
        /// <param name="externalUserDetails">
        /// Details about the entity this profile represents, as the platform states them. Each field sent replaces the stored value; omit a field to leave it unchanged. Once set, a value cannot be cleared and `null` is rejected. Accepted under the `user-profiles-2026-09-04` beta header only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateUserProfileRequestBody(
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? name,
            global::Anthropic.BetaUserProfileAccessType? accessType,
            global::System.DateTime? externalUserOnboardedAt,
            global::Anthropic.BetaUserProfileExternalUserDetailsParams? externalUserDetails)
        {
            this.ExternalId = externalId;
            this.Metadata = metadata;
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserOnboardedAt = externalUserOnboardedAt;
            this.ExternalUserDetails = externalUserDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserProfileRequestBody" /> class.
        /// </summary>
        public BetaUpdateUserProfileRequestBody()
        {
        }

    }
}