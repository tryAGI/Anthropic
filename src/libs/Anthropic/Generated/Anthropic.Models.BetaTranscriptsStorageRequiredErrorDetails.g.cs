
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// In an organization managed through AWS or Google Cloud, the request would leave the Workspace with `inference_data_privacy.human_review` disabled and `inference_data_privacy.transcripts_storage` not set to External Storage. With human review disabled, the organization reviews its own flagged requests, and it receives them only in that storage.
    /// </summary>
    public sealed partial class BetaTranscriptsStorageRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"transcripts_storage_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "transcripts_storage_required";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTranscriptsStorageRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTranscriptsStorageRequiredErrorDetails(
            string errorCode = "transcripts_storage_required")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTranscriptsStorageRequiredErrorDetails" /> class.
        /// </summary>
        public BetaTranscriptsStorageRequiredErrorDetails()
        {
        }

    }
}