
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A sort direction: `asc` or `desc`.
    /// </summary>
    public enum BetaComplianceReviewOrder
    {
        /// <summary>
        /// Oldest first.
        /// </summary>
        Asc,
        /// <summary>
        /// Newest first.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewOrder value)
        {
            return value switch
            {
                BetaComplianceReviewOrder.Asc => "asc",
                BetaComplianceReviewOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaComplianceReviewOrder.Asc,
                "desc" => BetaComplianceReviewOrder.Desc,
                _ => null,
            };
        }
    }
}