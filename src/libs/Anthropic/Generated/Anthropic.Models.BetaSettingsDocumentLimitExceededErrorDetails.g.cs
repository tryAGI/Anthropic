
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has reached its limit of settings documents, counting unused ones. An owner can remove unused documents in claude.ai. Deleting a group's settings or clearing the default settings also frees a document, if nothing else uses it. None of these works once the organization has also reached its settings history limit.
    /// </summary>
    public sealed partial class BetaSettingsDocumentLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"settings_document_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "settings_document_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSettingsDocumentLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSettingsDocumentLimitExceededErrorDetails(
            string errorCode = "settings_document_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSettingsDocumentLimitExceededErrorDetails" /> class.
        /// </summary>
        public BetaSettingsDocumentLimitExceededErrorDetails()
        {
        }

    }
}