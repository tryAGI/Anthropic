
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Human review can't be set as requested on this Workspace, so the request changed nothing. The error's `message` says what to do instead.
    /// </summary>
    public sealed partial class BetaHumanReviewNotAvailableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"human_review_not_available"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "human_review_not_available";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHumanReviewNotAvailableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaHumanReviewNotAvailableErrorDetails(
            string errorCode = "human_review_not_available")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHumanReviewNotAvailableErrorDetails" /> class.
        /// </summary>
        public BetaHumanReviewNotAvailableErrorDetails()
        {
        }

    }
}