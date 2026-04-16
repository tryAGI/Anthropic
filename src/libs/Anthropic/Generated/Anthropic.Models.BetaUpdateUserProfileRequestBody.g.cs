
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateUserProfileRequestBody(
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.ExternalId = externalId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserProfileRequestBody" /> class.
        /// </summary>
        public BetaUpdateUserProfileRequestBody()
        {
        }
    }
}