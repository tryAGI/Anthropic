
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One check that a verification attempt failed.
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageFailedCheck
    {
        /// <summary>
        /// Which check failed, such as `label_mismatch` or `grant_mismatch`. Anthropic may add values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaGoogleManagedStorageFailedCheckCheckJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaGoogleManagedStorageFailedCheckCheck Check { get; set; }

        /// <summary>
        /// On a check about one of the accounts that Anthropic uses to reach the bucket, that account's kind of access, such as `ingest`. `null` on any other check. Anthropic may add values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Anthropic.BetaGoogleManagedStorageFailedCheckRole? Role { get; set; }

        /// <summary>
        /// What failed and, where the end customer can fix it, what to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageFailedCheck" /> class.
        /// </summary>
        /// <param name="check">
        /// Which check failed, such as `label_mismatch` or `grant_mismatch`. Anthropic may add values.
        /// </param>
        /// <param name="message">
        /// What failed and, where the end customer can fix it, what to change.
        /// </param>
        /// <param name="role">
        /// On a check about one of the accounts that Anthropic uses to reach the bucket, that account's kind of access, such as `ingest`. `null` on any other check. Anthropic may add values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageFailedCheck(
            global::Anthropic.BetaGoogleManagedStorageFailedCheckCheck check,
            string message,
            global::Anthropic.BetaGoogleManagedStorageFailedCheckRole? role)
        {
            this.Check = check;
            this.Role = role;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageFailedCheck" /> class.
        /// </summary>
        public BetaGoogleManagedStorageFailedCheck()
        {
        }

    }
}