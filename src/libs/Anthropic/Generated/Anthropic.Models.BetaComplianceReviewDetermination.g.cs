
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A conclusion on flagged messages: `violation` or `no_violation`.
    /// </summary>
    public enum BetaComplianceReviewDetermination
    {
        /// <summary>
        /// The messages violated no policy.
        /// </summary>
        NoViolation,
        /// <summary>
        /// The messages violated a policy.
        /// </summary>
        Violation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewDeterminationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewDetermination value)
        {
            return value switch
            {
                BetaComplianceReviewDetermination.NoViolation => "no_violation",
                BetaComplianceReviewDetermination.Violation => "violation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewDetermination? ToEnum(string value)
        {
            return value switch
            {
                "no_violation" => BetaComplianceReviewDetermination.NoViolation,
                "violation" => BetaComplianceReviewDetermination.Violation,
                _ => null,
            };
        }
    }
}