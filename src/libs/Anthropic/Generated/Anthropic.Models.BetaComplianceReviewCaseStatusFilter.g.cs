
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A review case status to filter by: `open` or `closed`.
    /// </summary>
    public enum BetaComplianceReviewCaseStatusFilter
    {
        /// <summary>
        /// Cases that Anthropic has stopped waiting on.
        /// </summary>
        Closed,
        /// <summary>
        /// Cases that Anthropic is waiting for a response to.
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewCaseStatusFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewCaseStatusFilter value)
        {
            return value switch
            {
                BetaComplianceReviewCaseStatusFilter.Closed => "closed",
                BetaComplianceReviewCaseStatusFilter.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewCaseStatusFilter? ToEnum(string value)
        {
            return value switch
            {
                "closed" => BetaComplianceReviewCaseStatusFilter.Closed,
                "open" => BetaComplianceReviewCaseStatusFilter.Open,
                _ => null,
            };
        }
    }
}