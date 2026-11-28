
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request would leave the Workspace with `inference_data_privacy.safeguards_storage` set to External Storage and `inference_data_privacy.human_review` enabled. Anthropic doesn't offer human review of data in a customer's own storage. Set `human_review` to `disabled`, or `safeguards_storage` to `internal`.
    /// </summary>
    public sealed partial class BetaHumanReviewOnWithExternalStorageErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"human_review_on_with_external_storage"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "human_review_on_with_external_storage";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHumanReviewOnWithExternalStorageErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaHumanReviewOnWithExternalStorageErrorDetails(
            string errorCode = "human_review_on_with_external_storage")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHumanReviewOnWithExternalStorageErrorDetails" /> class.
        /// </summary>
        public BetaHumanReviewOnWithExternalStorageErrorDetails()
        {
        }

    }
}