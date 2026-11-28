
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `responded` means that Anthropic recorded a response. `window_ended` means that the time to respond ended with no response. `ended_by_anthropic` means that Anthropic ended the case before that time was over. New values can appear, so accept a value that you don't know.
    /// </summary>
    public enum BetaComplianceReviewCaseCloseReasonType
    {
        /// <summary>
        ///
        /// </summary>
        EndedByAnthropic,
        /// <summary>
        ///
        /// </summary>
        Responded,
        /// <summary>
        ///
        /// </summary>
        WindowEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewCaseCloseReasonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewCaseCloseReasonType value)
        {
            return value switch
            {
                BetaComplianceReviewCaseCloseReasonType.EndedByAnthropic => "ended_by_anthropic",
                BetaComplianceReviewCaseCloseReasonType.Responded => "responded",
                BetaComplianceReviewCaseCloseReasonType.WindowEnded => "window_ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewCaseCloseReasonType? ToEnum(string value)
        {
            return value switch
            {
                "ended_by_anthropic" => BetaComplianceReviewCaseCloseReasonType.EndedByAnthropic,
                "responded" => BetaComplianceReviewCaseCloseReasonType.Responded,
                "window_ended" => BetaComplianceReviewCaseCloseReasonType.WindowEnded,
                _ => null,
            };
        }
    }
}