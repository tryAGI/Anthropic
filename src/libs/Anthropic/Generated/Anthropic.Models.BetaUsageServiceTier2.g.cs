
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
        Batch,
        /// <summary>
        /// 
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Standard,
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
                BetaUsageServiceTier2.Batch => "batch",
                BetaUsageServiceTier2.Priority => "priority",
                BetaUsageServiceTier2.Standard => "standard",
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
                "batch" => BetaUsageServiceTier2.Batch,
                "priority" => BetaUsageServiceTier2.Priority,
                "standard" => BetaUsageServiceTier2.Standard,
                _ => null,
            };
        }
    }
}