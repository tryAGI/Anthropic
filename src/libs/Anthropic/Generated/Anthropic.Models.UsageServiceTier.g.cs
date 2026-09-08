
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum UsageServiceTier
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
    public static class UsageServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageServiceTier value)
        {
            return value switch
            {
                UsageServiceTier.Batch => "batch",
                UsageServiceTier.Priority => "priority",
                UsageServiceTier.Standard => "standard",
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
                "batch" => UsageServiceTier.Batch,
                "priority" => UsageServiceTier.Priority,
                "standard" => UsageServiceTier.Standard,
                _ => null,
            };
        }
    }
}