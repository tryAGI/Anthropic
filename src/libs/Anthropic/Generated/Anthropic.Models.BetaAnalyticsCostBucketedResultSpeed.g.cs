
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAnalyticsCostBucketedResultSpeed
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
    public static class BetaAnalyticsCostBucketedResultSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAnalyticsCostBucketedResultSpeed value)
        {
            return value switch
            {
                BetaAnalyticsCostBucketedResultSpeed.Fast => "fast",
                BetaAnalyticsCostBucketedResultSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAnalyticsCostBucketedResultSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaAnalyticsCostBucketedResultSpeed.Fast,
                "standard" => BetaAnalyticsCostBucketedResultSpeed.Standard,
                _ => null,
            };
        }
    }
}