
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewReadReasonDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SafeguardsReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewReadReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewReadReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceReviewReadReasonDiscriminatorType.SafeguardsReview => "safeguards_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewReadReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "safeguards_review" => BetaComplianceReviewReadReasonDiscriminatorType.SafeguardsReview,
                _ => null,
            };
        }
    }
}