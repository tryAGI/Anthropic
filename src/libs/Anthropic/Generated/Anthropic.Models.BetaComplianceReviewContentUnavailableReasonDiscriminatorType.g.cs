
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewContentUnavailableReasonDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        NotCaptured,
        /// <summary>
        ///
        /// </summary>
        StoredCopyUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewContentUnavailableReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewContentUnavailableReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceReviewContentUnavailableReasonDiscriminatorType.NotCaptured => "not_captured",
                BetaComplianceReviewContentUnavailableReasonDiscriminatorType.StoredCopyUnavailable => "stored_copy_unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewContentUnavailableReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "not_captured" => BetaComplianceReviewContentUnavailableReasonDiscriminatorType.NotCaptured,
                "stored_copy_unavailable" => BetaComplianceReviewContentUnavailableReasonDiscriminatorType.StoredCopyUnavailable,
                _ => null,
            };
        }
    }
}