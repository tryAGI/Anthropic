
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"external_user_details":{"account_status":"suspended"}}
    /// </summary>
    public sealed partial class UpdateUserProfileRequestBody
    {
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
        public global::Anthropic.UserProfileAccessType? AccessType { get; set; }

        /// <summary>
        /// Details about the entity this profile represents, as the platform states them. Each field sent replaces the stored value; omit a field to leave it unchanged. Once set, a value cannot be cleared and `null` is rejected. Not accepted under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_details")]
        public global::Anthropic.UserProfileExternalUserDetailsParams? ExternalUserDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserProfileRequestBody" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Key-value pairs to merge into the stored metadata. Keys provided overwrite existing values. To remove a key, set its value to an empty string. Keys not provided are left unchanged. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters.
        /// </param>
        /// <param name="name">
        /// If present, replaces the stored name. Omit to leave unchanged. Maximum 255 characters.
        /// </param>
        /// <param name="accessType">
        /// If present, replaces the stored access type. Omit to leave unchanged.
        /// </param>
        /// <param name="externalUserDetails">
        /// Details about the entity this profile represents, as the platform states them. Each field sent replaces the stored value; omit a field to leave it unchanged. Once set, a value cannot be cleared and `null` is rejected. Not accepted under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserProfileRequestBody(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? name,
            global::Anthropic.UserProfileAccessType? accessType,
            global::Anthropic.UserProfileExternalUserDetailsParams? externalUserDetails)
        {
            this.Metadata = metadata;
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserDetails = externalUserDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserProfileRequestBody" /> class.
        /// </summary>
        public UpdateUserProfileRequestBody()
        {
        }

    }
}