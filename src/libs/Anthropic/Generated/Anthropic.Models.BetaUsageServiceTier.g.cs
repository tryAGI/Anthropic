
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaUsageServiceTier
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
    public static class BetaUsageServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUsageServiceTier value)
        {
            return value switch
            {
                BetaUsageServiceTier.Batch => "batch",
                BetaUsageServiceTier.Priority => "priority",
                BetaUsageServiceTier.Standard => "standard",
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
                "batch" => BetaUsageServiceTier.Batch,
                "priority" => BetaUsageServiceTier.Priority,
                "standard" => BetaUsageServiceTier.Standard,
                _ => null,
            };
        }
    }
}