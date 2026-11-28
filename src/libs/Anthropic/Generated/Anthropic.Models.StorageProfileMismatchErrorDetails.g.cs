
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Workspace's storage and its user profile don't match: the Workspace and its storage must have the same user profile, or both have none.
    /// </summary>
    public sealed partial class StorageProfileMismatchErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_profile_mismatch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_profile_mismatch";

        /// <summary>
        /// The storage setting that doesn't match the Workspace's user profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageProfileMismatchErrorDetails" /> class.
        /// </summary>
        /// <param name="field">
        /// The storage setting that doesn't match the Workspace's user profile.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageProfileMismatchErrorDetails(
            string field,
            string errorCode = "storage_profile_mismatch")
        {
            this.ErrorCode = errorCode;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageProfileMismatchErrorDetails" /> class.
        /// </summary>
        public StorageProfileMismatchErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="StorageProfileMismatchErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static StorageProfileMismatchErrorDetails FromField(string field)
        {
            return new StorageProfileMismatchErrorDetails
            {
                Field = field,
            };
        }

    }
}