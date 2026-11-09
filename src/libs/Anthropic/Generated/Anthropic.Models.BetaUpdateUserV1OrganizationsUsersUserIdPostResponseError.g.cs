
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError
    {
        /// <summary>
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.BetaSandboxEgressRestrictedErrorDetails? Details { get; set; }

        /// <summary>
        /// A human-readable explanation of the error. Its wording can change, so don't match on it.<br/>
        /// Default Value: Permission denied
        /// </summary>
        /// <default>"Permission denied"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Permission denied";

        /// <summary>
        /// The broad category of the error.<br/>
        /// Default Value: permission_error
        /// </summary>
        /// <default>"permission_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "permission_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the error. Its wording can change, so don't match on it.<br/>
        /// Default Value: Permission denied
        /// </param>
        /// <param name="details">
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </param>
        /// <param name="type">
        /// The broad category of the error.<br/>
        /// Default Value: permission_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError(
            string message,
            global::Anthropic.BetaSandboxEgressRestrictedErrorDetails? details,
            string type = "permission_error")
        {
            this.Details = details;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError" /> class.
        /// </summary>
        public BetaUpdateUserV1OrganizationsUsersUserIdPostResponseError()
        {
        }

    }
}