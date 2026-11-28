
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why a review case closed.
    /// </summary>
    public sealed partial class BetaComplianceReviewCaseCloseReason
    {
        /// <summary>
        /// `responded` means that Anthropic recorded a response. `window_ended` means that the time to respond ended with no response. `ended_by_anthropic` means that Anthropic ended the case before that time was over. New values can appear, so accept a value that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewCaseCloseReasonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewCaseCloseReasonType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCaseCloseReason" /> class.
        /// </summary>
        /// <param name="type">
        /// `responded` means that Anthropic recorded a response. `window_ended` means that the time to respond ended with no response. `ended_by_anthropic` means that Anthropic ended the case before that time was over. New values can appear, so accept a value that you don't know.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewCaseCloseReason(
            global::Anthropic.BetaComplianceReviewCaseCloseReasonType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewCaseCloseReason" /> class.
        /// </summary>
        public BetaComplianceReviewCaseCloseReason()
        {
        }

    }
}