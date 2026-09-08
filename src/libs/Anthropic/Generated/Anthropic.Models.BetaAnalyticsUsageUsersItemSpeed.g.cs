
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageUsersItemSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsUsageUsersItemSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageUsersItemSpeed value)
        {
            return value switch
            {
                BetaAnalyticsUsageUsersItemSpeed.Fast => "fast",
                BetaAnalyticsUsageUsersItemSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageUsersItemSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaAnalyticsUsageUsersItemSpeed.Fast,
                "standard" => BetaAnalyticsUsageUsersItemSpeed.Standard,
                _ => null,
            };
        }
    }
}