
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewCaseStatusDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewCaseStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewCaseStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceReviewCaseStatusDiscriminatorType.Closed => "closed",
                BetaComplianceReviewCaseStatusDiscriminatorType.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewCaseStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "closed" => BetaComplianceReviewCaseStatusDiscriminatorType.Closed,
                "open" => BetaComplianceReviewCaseStatusDiscriminatorType.Open,
                _ => null,
            };
        }
    }
}