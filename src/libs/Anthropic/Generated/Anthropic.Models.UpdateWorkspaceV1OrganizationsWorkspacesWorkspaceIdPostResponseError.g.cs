
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError
    {
        /// <summary>
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ExternalKeyValidationFailedErrorDetails, global::Anthropic.ExternalKeyValidationTimedOutErrorDetails, global::Anthropic.KeyProfileMismatchErrorDetails, global::Anthropic.UserProfileNotFoundErrorDetails, global::Anthropic.WorkspacePolicyViolationErrorDetails>))]
        public global::Anthropic.AnyOf<global::Anthropic.ExternalKeyValidationFailedErrorDetails, global::Anthropic.ExternalKeyValidationTimedOutErrorDetails, global::Anthropic.KeyProfileMismatchErrorDetails, global::Anthropic.UserProfileNotFoundErrorDetails, global::Anthropic.WorkspacePolicyViolationErrorDetails>? Details { get; set; }

        /// <summary>
        /// A human-readable explanation of the error. Its wording can change, so don't match on it.<br/>
        /// Default Value: Invalid request
        /// </summary>
        /// <default>"Invalid request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Invalid request";

        /// <summary>
        /// The broad category of the error.<br/>
        /// Default Value: invalid_request_error
        /// </summary>
        /// <default>"invalid_request_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invalid_request_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the error. Its wording can change, so don't match on it.<br/>
        /// Default Value: Invalid request
        /// </param>
        /// <param name="details">
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </param>
        /// <param name="type">
        /// The broad category of the error.<br/>
        /// Default Value: invalid_request_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError(
            string message,
            global::Anthropic.AnyOf<global::Anthropic.ExternalKeyValidationFailedErrorDetails, global::Anthropic.ExternalKeyValidationTimedOutErrorDetails, global::Anthropic.KeyProfileMismatchErrorDetails, global::Anthropic.UserProfileNotFoundErrorDetails, global::Anthropic.WorkspacePolicyViolationErrorDetails>? details,
            string type = "invalid_request_error")
        {
            this.Details = details;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError" /> class.
        /// </summary>
        public UpdateWorkspaceV1OrganizationsWorkspacesWorkspaceIdPostResponseError()
        {
        }

    }
}