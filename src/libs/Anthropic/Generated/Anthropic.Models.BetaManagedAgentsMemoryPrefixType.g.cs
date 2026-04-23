
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryPrefixType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryPrefix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryPrefixTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryPrefixType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryPrefixType.MemoryPrefix => "memory_prefix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryPrefixType? ToEnum(string value)
        {
            return value switch
            {
                "memory_prefix" => BetaManagedAgentsMemoryPrefixType.MemoryPrefix,
                _ => null,
            };
        }
    }
}