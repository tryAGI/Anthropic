
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One check that a verification attempt failed.
    /// </summary>
    public sealed partial class BetaStorageFailedCheck
    {
        /// <summary>
        /// Which check failed, such as `label_mismatch` or `grant_mismatch`. Anthropic may add values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaStorageFailedCheckCheckJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaStorageFailedCheckCheck Check { get; set; }

        /// <summary>
        /// What failed and, where you can fix it, what to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// On a check about one of the accounts that Anthropic uses to reach the bucket, that account's kind of access, such as `ingest`. `null` on any other check. Anthropic may add values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Anthropic.BetaStorageFailedCheckRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageFailedCheck" /> class.
        /// </summary>
        /// <param name="check">
        /// Which check failed, such as `label_mismatch` or `grant_mismatch`. Anthropic may add values.
        /// </param>
        /// <param name="message">
        /// What failed and, where you can fix it, what to change.
        /// </param>
        /// <param name="role">
        /// On a check about one of the accounts that Anthropic uses to reach the bucket, that account's kind of access, such as `ingest`. `null` on any other check. Anthropic may add values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageFailedCheck(
            global::Anthropic.BetaStorageFailedCheckCheck check,
            string message,
            global::Anthropic.BetaStorageFailedCheckRole? role)
        {
            this.Check = check;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageFailedCheck" /> class.
        /// </summary>
        public BetaStorageFailedCheck()
        {
        }

    }
}