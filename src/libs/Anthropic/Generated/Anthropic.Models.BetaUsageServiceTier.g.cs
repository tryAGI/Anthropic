
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// If the request used the priority, standard, or batch tier.
    /// </summary>
    public enum BetaUsageServiceTier
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
    public static class BetaUsageServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUsageServiceTier value)
        {
            return value switch
            {
                BetaUsageServiceTier.Standard => "standard",
                BetaUsageServiceTier.Priority => "priority",
                BetaUsageServiceTier.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUsageServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "standard" => BetaUsageServiceTier.Standard,
                "priority" => BetaUsageServiceTier.Priority,
                "batch" => BetaUsageServiceTier.Batch,
                _ => null,
            };
        }
    }
}