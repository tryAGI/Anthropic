
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsCostUsersItemSpeed
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
    public static class BetaAnalyticsCostUsersItemSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsCostUsersItemSpeed value)
        {
            return value switch
            {
                BetaAnalyticsCostUsersItemSpeed.Fast => "fast",
                BetaAnalyticsCostUsersItemSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsCostUsersItemSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaAnalyticsCostUsersItemSpeed.Fast,
                "standard" => BetaAnalyticsCostUsersItemSpeed.Standard,
                _ => null,
            };
        }
    }
}