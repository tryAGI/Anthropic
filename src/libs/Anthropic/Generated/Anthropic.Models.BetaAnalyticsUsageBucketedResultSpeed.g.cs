
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsUsageBucketedResultSpeed
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
    public static class BetaAnalyticsUsageBucketedResultSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsUsageBucketedResultSpeed value)
        {
            return value switch
            {
                BetaAnalyticsUsageBucketedResultSpeed.Fast => "fast",
                BetaAnalyticsUsageBucketedResultSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsUsageBucketedResultSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaAnalyticsUsageBucketedResultSpeed.Fast,
                "standard" => BetaAnalyticsUsageBucketedResultSpeed.Standard,
                _ => null,
            };
        }
    }
}