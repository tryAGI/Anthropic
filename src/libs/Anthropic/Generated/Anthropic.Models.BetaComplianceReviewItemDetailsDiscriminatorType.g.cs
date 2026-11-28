
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewItemDetailsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewItemDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewItemDetailsDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceReviewItemDetailsDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewItemDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message" => BetaComplianceReviewItemDetailsDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}