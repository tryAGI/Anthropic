
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaHumanReviewType
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaHumanReviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaHumanReviewType value)
        {
            return value switch
            {
                BetaHumanReviewType.Disabled => "disabled",
                BetaHumanReviewType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaHumanReviewType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaHumanReviewType.Disabled,
                "enabled" => BetaHumanReviewType.Enabled,
                _ => null,
            };
        }
    }
}