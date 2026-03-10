
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageServiceTier2
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
    public static class UsageServiceTier2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageServiceTier2 value)
        {
            return value switch
            {
                UsageServiceTier2.Standard => "standard",
                UsageServiceTier2.Priority => "priority",
                UsageServiceTier2.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageServiceTier2? ToEnum(string value)
        {
            return value switch
            {
                "standard" => UsageServiceTier2.Standard,
                "priority" => UsageServiceTier2.Priority,
                "batch" => UsageServiceTier2.Batch,
                _ => null,
            };
        }
    }
}