
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// If the request used the priority, standard, or batch tier.
    /// </summary>
    public enum UsageServiceTier
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
    public static class UsageServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageServiceTier value)
        {
            return value switch
            {
                UsageServiceTier.Standard => "standard",
                UsageServiceTier.Priority => "priority",
                UsageServiceTier.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "standard" => UsageServiceTier.Standard,
                "priority" => UsageServiceTier.Priority,
                "batch" => UsageServiceTier.Batch,
                _ => null,
            };
        }
    }
}