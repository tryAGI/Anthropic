
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewMessageContentDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CreateMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewMessageContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewMessageContentDiscriminatorType value)
        {
            return value switch
            {
                BetaComplianceReviewMessageContentDiscriminatorType.CreateMessage => "create_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewMessageContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_message" => BetaComplianceReviewMessageContentDiscriminatorType.CreateMessage,
                _ => null,
            };
        }
    }
}