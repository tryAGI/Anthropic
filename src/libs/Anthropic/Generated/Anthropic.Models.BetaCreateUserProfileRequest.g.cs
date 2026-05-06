
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"external_id":"user_12345","metadata":{}}
    /// </summary>
    public sealed partial class BetaCreateUserProfileRequest
    {
        /// <summary>
        /// Platform's own identifier for this user. Not enforced unique. Maximum 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Display name of the entity this profile represents. Required when relationship is `resold` (the resold-to company's name); optional otherwise. Maximum 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How the entity relates to the platform. `external` (default): an individual end-user. `resold`: a company the platform resells Claude access to. `internal`: the platform's own usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationship")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUserProfileRelationshipJsonConverter))]
        public global::Anthropic.BetaUserProfileRelationship? Relationship { get; set; }

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
        /// Platform's own identifier for this user. Not enforced unique. Maximum 255 characters.
        /// </param>
        /// <param name="name">
        /// Display name of the entity this profile represents. Required when relationship is `resold` (the resold-to company's name); optional otherwise. Maximum 255 characters.
        /// </param>
        /// <param name="relationship">
        /// How the entity relates to the platform. `external` (default): an individual end-user. `resold`: a company the platform resells Claude access to. `internal`: the platform's own usage.
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
            global::Anthropic.BetaUserProfileRelationship? relationship,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.ExternalId = externalId;
            this.Name = name;
            this.Relationship = relationship;
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