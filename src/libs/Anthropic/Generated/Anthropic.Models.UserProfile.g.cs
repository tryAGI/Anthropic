
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A record of an entity that the platform serves through the API, such as an end-user of the platform's product or a company that the platform resells Claude access to.<br/>
    /// A Messages, Message Batches or token counting request can send a profile's `id` in the `anthropic-user-profile-id` header to attribute the request to that entity.<br/>
    /// Example: {"id":"uprof_011CZkZCu8hGbp5mYRQgUmz9","type":"user_profile","name":"Example User","access_type":"application","programs":{"cyber":{"status":"active","tiers":{"a":{"status":"inactive"},"b":{"status":"inactive"},"c":{"status":"inactive"}},"requirements":null},"efs":null},"external_user_details":{"reference_id":"user_12345","onboarded_at":"2024-11-02T08:15:00Z","account_status":"active","entity_type":"business","country":"US","name_hash":null,"email_hash":null},"enforcement_status":"unrestricted","enforcement_actions":[],"metadata":{},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
    /// </summary>
    public sealed partial class UserProfile
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
        /// <default>"user_profile"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user_profile";

        /// <summary>
        /// Real-world name of the entity this profile represents (company or individual). For a company the platform resells Claude access to (`access_type` `passthrough`) this is that company's name. `null` until the platform supplies one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How the platform uses the API for this entity: `application` (default) or `passthrough`. Absent under the legacy `user-profiles-2026-03-24` beta header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileAccessTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileAccessType AccessType { get; set; }

        /// <summary>
        /// Details about the entity this profile represents, as the platform states them; not verified by Anthropic. Every field is present, `null` until the platform supplies a value. Absent under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers, which serve `reference_id` as the top-level `external_id` and, under `user-profiles-2026-08-18`, `onboarded_at` as `external_user_onboarded_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileExternalUserDetails ExternalUserDetails { get; set; }

        /// <summary>
        /// Anthropic's enforcement status of this profile, from its open enforcement actions and any identity check under review, by the first rule that applies: `banned` while any open action is a `ban`; `pending` while a restriction that an identity check can clear is open, the end user has submitted that check, Anthropic's review of it has not ended, and no open action's `reason` is `account_compromise`; `restricted` while any action is open; `unrestricted` while none is. Absent under the `user-profiles-2026-09-04` and earlier beta headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileEnforcementStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileEnforcementStatus EnforcementStatus { get; set; }

        /// <summary>
        /// The enforcement actions open on this profile; empty when none is open. Absent under the `user-profiles-2026-09-04` and earlier beta headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement_actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementAction> EnforcementActions { get; set; }

        /// <summary>
        /// The profile's standing in each Anthropic program, such as the Cyber Verification Program. Present when the request sends no user-profiles beta header; absent under the `user-profiles-2026-09-04` and earlier beta headers, which serve `trust_grants` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("programs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfilePrograms Programs { get; set; }

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
        /// When this user profile was last modified, in RFC 3339 format. It normally also updates shortly after Anthropic gives the profile an approval or withdraws one. Other changes to the statuses that Anthropic reports do not always update it, so read the status itself rather than watching this timestamp.
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
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this user profile, prefixed `uprof_`.
        /// </param>
        /// <param name="accessType">
        /// How the platform uses the API for this entity: `application` (default) or `passthrough`. Absent under the legacy `user-profiles-2026-03-24` beta header.
        /// </param>
        /// <param name="externalUserDetails">
        /// Details about the entity this profile represents, as the platform states them; not verified by Anthropic. Every field is present, `null` until the platform supplies a value. Absent under the legacy `user-profiles-2026-03-24` and `user-profiles-2026-08-18` beta headers, which serve `reference_id` as the top-level `external_id` and, under `user-profiles-2026-08-18`, `onboarded_at` as `external_user_onboarded_at`.
        /// </param>
        /// <param name="enforcementStatus">
        /// Anthropic's enforcement status of this profile, from its open enforcement actions and any identity check under review, by the first rule that applies: `banned` while any open action is a `ban`; `pending` while a restriction that an identity check can clear is open, the end user has submitted that check, Anthropic's review of it has not ended, and no open action's `reason` is `account_compromise`; `restricted` while any action is open; `unrestricted` while none is. Absent under the `user-profiles-2026-09-04` and earlier beta headers.
        /// </param>
        /// <param name="enforcementActions">
        /// The enforcement actions open on this profile; empty when none is open. Absent under the `user-profiles-2026-09-04` and earlier beta headers.
        /// </param>
        /// <param name="programs">
        /// The profile's standing in each Anthropic program, such as the Cyber Verification Program. Present when the request sends no user-profiles beta header; absent under the `user-profiles-2026-09-04` and earlier beta headers, which serve `trust_grants` instead.
        /// </param>
        /// <param name="createdAt">
        /// When this user profile was created, in RFC 3339 format.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
        /// <param name="updatedAt">
        /// When this user profile was last modified, in RFC 3339 format. It normally also updates shortly after Anthropic gives the profile an approval or withdraws one. Other changes to the statuses that Anthropic reports do not always update it, so read the status itself rather than watching this timestamp.
        /// </param>
        /// <param name="name">
        /// Real-world name of the entity this profile represents (company or individual). For a company the platform resells Claude access to (`access_type` `passthrough`) this is that company's name. `null` until the platform supplies one.
        /// </param>
        /// <param name="type">
        /// Object type. Always `user_profile`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfile(
            string id,
            global::Anthropic.UserProfileAccessType accessType,
            global::Anthropic.UserProfileExternalUserDetails externalUserDetails,
            global::Anthropic.UserProfileEnforcementStatus enforcementStatus,
            global::System.Collections.Generic.IList<global::Anthropic.UserProfileEnforcementAction> enforcementActions,
            global::Anthropic.UserProfilePrograms programs,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime updatedAt,
            string? name,
            string type = "user_profile")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name;
            this.AccessType = accessType;
            this.ExternalUserDetails = externalUserDetails ?? throw new global::System.ArgumentNullException(nameof(externalUserDetails));
            this.EnforcementStatus = enforcementStatus;
            this.EnforcementActions = enforcementActions ?? throw new global::System.ArgumentNullException(nameof(enforcementActions));
            this.Programs = programs ?? throw new global::System.ArgumentNullException(nameof(programs));
            this.CreatedAt = createdAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        public UserProfile()
        {
        }

    }
}