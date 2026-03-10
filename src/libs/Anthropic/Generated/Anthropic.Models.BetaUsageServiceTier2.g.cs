
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaUsageServiceTier2
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUsageServiceTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUsageServiceTier2 value)
        {
            return value switch
            {
                BetaUsageServiceTier2.Standard => "standard",
                BetaUsageServiceTier2.Priority => "priority",
                BetaUsageServiceTier2.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUsageServiceTier2? ToEnum(string value)
        {
            return value switch
            {
                "standard" => BetaUsageServiceTier2.Standard,
                "priority" => BetaUsageServiceTier2.Priority,
                "batch" => BetaUsageServiceTier2.Batch,
                _ => null,
            };
        }
    }
}