
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMessagesCountTokensPostResponseError
    {
        /// <summary>
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>))]
        public global::Anthropic.AnyOf<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>? Details { get; set; }

        /// <summary>
        /// Default Value: Invalid request
        /// </summary>
        /// <default>"Invalid request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Invalid request";

        /// <summary>
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
        /// Initializes a new instance of the <see cref="BetaMessagesCountTokensPostResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Invalid request
        /// </param>
        /// <param name="details">
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </param>
        /// <param name="type">
        /// Default Value: invalid_request_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessagesCountTokensPostResponseError(
            string message,
            global::Anthropic.AnyOf<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>? details,
            string type = "invalid_request_error")
        {
            this.Details = details;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesCountTokensPostResponseError" /> class.
        /// </summary>
        public BetaMessagesCountTokensPostResponseError()
        {
        }

    }
}