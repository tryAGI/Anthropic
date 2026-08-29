
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMessagesUsageReportTimeBucketWidth
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
    public static class BetaMessagesUsageReportTimeBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessagesUsageReportTimeBucketWidth value)
        {
            return value switch
            {
                BetaMessagesUsageReportTimeBucketWidth.x1d => "1d",
                BetaMessagesUsageReportTimeBucketWidth.x1h => "1h",
                BetaMessagesUsageReportTimeBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessagesUsageReportTimeBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => BetaMessagesUsageReportTimeBucketWidth.x1d,
                "1h" => BetaMessagesUsageReportTimeBucketWidth.x1h,
                "1m" => BetaMessagesUsageReportTimeBucketWidth.x1m,
                _ => null,
            };
        }
    }
}