
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"external_id":"user_12345"}
    /// </summary>
    public sealed partial class BetaUpdateUserProfileRequestBody
    {
        /// <summary>
        /// If present, replaces the stored external_id. Omit to leave unchanged. Maximum 255 characters.
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
        /// If present, replaces the stored account creation time. Omit to leave unchanged; once set, the value cannot be cleared and `null` is rejected. Must be a complete RFC 3339 timestamp no more than 1 minute in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_onboarded_at")]
        public global::System.DateTime? ExternalUserOnboardedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserProfileRequestBody" /> class.
        /// </summary>
        /// <param name="externalId">
        /// If present, replaces the stored external_id. Omit to leave unchanged. Maximum 255 characters.
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
        /// If present, replaces the stored account creation time. Omit to leave unchanged; once set, the value cannot be cleared and `null` is rejected. Must be a complete RFC 3339 timestamp no more than 1 minute in the future.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateUserProfileRequestBody(
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? name,
            global::Anthropic.BetaUserProfileAccessType? accessType,
            global::System.DateTime? externalUserOnboardedAt)
        {
            this.ExternalId = externalId;
            this.Metadata = metadata;
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserOnboardedAt = externalUserOnboardedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserProfileRequestBody" /> class.
        /// </summary>
        public BetaUpdateUserProfileRequestBody()
        {
        }

    }
}