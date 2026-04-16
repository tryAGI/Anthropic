
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
        /// <param name="metadata">
        /// Free-form key-value data to attach to this user profile. Maximum 16 keys, with keys up to 64 characters and values up to 512 characters. Values must be non-empty strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateUserProfileRequest(
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.ExternalId = externalId;
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