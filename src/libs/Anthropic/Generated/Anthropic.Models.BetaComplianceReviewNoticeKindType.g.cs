
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `response_requested` asks you to respond to the cases in `case_ids`. For `warning` and `question`, `message` explains how to answer if an answer is needed. New values can appear, so accept a value that you don't know.
    /// </summary>
    public enum BetaComplianceReviewNoticeKindType
    {
        /// <summary>
        ///
        /// </summary>
        Question,
        /// <summary>
        ///
        /// </summary>
        ResponseRequested,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewNoticeKindTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewNoticeKindType value)
        {
            return value switch
            {
                BetaComplianceReviewNoticeKindType.Question => "question",
                BetaComplianceReviewNoticeKindType.ResponseRequested => "response_requested",
                BetaComplianceReviewNoticeKindType.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewNoticeKindType? ToEnum(string value)
        {
            return value switch
            {
                "question" => BetaComplianceReviewNoticeKindType.Question,
                "response_requested" => BetaComplianceReviewNoticeKindType.ResponseRequested,
                "warning" => BetaComplianceReviewNoticeKindType.Warning,
                _ => null,
            };
        }
    }
}