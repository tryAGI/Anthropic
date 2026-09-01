
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"id":"uprof_011CZkZCu8hGbp5mYRQgUmz9","type":"user_profile","external_id":"user_12345","name":"Example User","access_type":"application","trust_grants":{"cyber":{"status":"active"}},"external_user_onboarded_at":"2024-11-02T08:15:00Z","metadata":{},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
    /// </summary>
    public sealed partial class BetaUserProfile
    {
        /// <summary>
        /// Unique identifier for this user profile, prefixed `uprof_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type. Always `user_profile`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUserProfileTypeJsonConverter))]
        public global::Anthropic.BetaUserProfileType Type { get; set; }

        /// <summary>
        /// Platform's own identifier for this user. Not enforced unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Real-world name of the entity this profile represents (company or individual). For a company the platform resells Claude access to (`access_type` `passthrough`) this is that company's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How the platform uses the API for this entity: `application` (default) or `passthrough`. Present under the `user-profiles-2026-08-18` beta header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUserProfileAccessTypeJsonConverter))]
        public global::Anthropic.BetaUserProfileAccessType? AccessType { get; set; }

        /// <summary>
        /// When the entity this profile represents opened its account with the platform, as stated by the platform, in RFC 3339 format (UTC). `null` until the platform supplies one. Present under the `user-profiles-2026-08-18` beta header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_onboarded_at")]
        public global::System.DateTime? ExternalUserOnboardedAt { get; set; }

        /// <summary>
        /// Trust grants for this profile, keyed by grant name. Key omitted when no grant is active or in flight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_grants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant> TrustGrants { get; set; }

        /// <summary>
        /// When this user profile was created, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// When this user profile was last modified, in RFC 3339 format. Trust-grant status changes also bump this timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this user profile, prefixed `uprof_`.
        /// </param>
        /// <param name="trustGrants">
        /// Trust grants for this profile, keyed by grant name. Key omitted when no grant is active or in flight.
        /// </param>
        /// <param name="createdAt">
        /// When this user profile was created, in RFC 3339 format.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="updatedAt">
        /// When this user profile was last modified, in RFC 3339 format. Trust-grant status changes also bump this timestamp.
        /// </param>
        /// <param name="type">
        /// Object type. Always `user_profile`.
        /// </param>
        /// <param name="externalId">
        /// Platform's own identifier for this user. Not enforced unique.
        /// </param>
        /// <param name="name">
        /// Real-world name of the entity this profile represents (company or individual). For a company the platform resells Claude access to (`access_type` `passthrough`) this is that company's name.
        /// </param>
        /// <param name="accessType">
        /// How the platform uses the API for this entity: `application` (default) or `passthrough`. Present under the `user-profiles-2026-08-18` beta header.
        /// </param>
        /// <param name="externalUserOnboardedAt">
        /// When the entity this profile represents opened its account with the platform, as stated by the platform, in RFC 3339 format (UTC). `null` until the platform supplies one. Present under the `user-profiles-2026-08-18` beta header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfile(
            string id,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.BetaUserProfileTrustGrant> trustGrants,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaUserProfileType type,
            string? externalId,
            string? name,
            global::Anthropic.BetaUserProfileAccessType? accessType,
            global::System.DateTime? externalUserOnboardedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ExternalId = externalId;
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserOnboardedAt = externalUserOnboardedAt;
            this.TrustGrants = trustGrants ?? throw new global::System.ArgumentNullException(nameof(trustGrants));
            this.CreatedAt = createdAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfile" /> class.
        /// </summary>
        public BetaUserProfile()
        {
        }

    }
}