
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The kind of a review notice.
    /// </summary>
    public sealed partial class BetaComplianceReviewNoticeKind
    {
        /// <summary>
        /// `response_requested` asks you to respond to the cases in `case_ids`. For `warning` and `question`, `message` explains how to answer if an answer is needed. New values can appear, so accept a value that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaComplianceReviewNoticeKindTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaComplianceReviewNoticeKindType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewNoticeKind" /> class.
        /// </summary>
        /// <param name="type">
        /// `response_requested` asks you to respond to the cases in `case_ids`. For `warning` and `question`, `message` explains how to answer if an answer is needed. New values can appear, so accept a value that you don't know.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewNoticeKind(
            global::Anthropic.BetaComplianceReviewNoticeKindType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewNoticeKind" /> class.
        /// </summary>
        public BetaComplianceReviewNoticeKind()
        {
        }

    }
}