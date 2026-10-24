
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsTimeBucketWidth
    {
        /// <summary>
        ///
        /// </summary>
        x1d,
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAnalyticsTimeBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsTimeBucketWidth value)
        {
            return value switch
            {
                BetaAnalyticsTimeBucketWidth.x1d => "1d",
                BetaAnalyticsTimeBucketWidth.x1h => "1h",
                BetaAnalyticsTimeBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsTimeBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaAnalyticsTimeBucketWidth.x1d,
                "1h" => BetaAnalyticsTimeBucketWidth.x1h,
                "1m" => BetaAnalyticsTimeBucketWidth.x1m,
                _ => null,
            };
        }
    }
}