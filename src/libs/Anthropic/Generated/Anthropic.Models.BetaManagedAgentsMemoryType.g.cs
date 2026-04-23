
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Memory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryType.Memory => "memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "memory" => BetaManagedAgentsMemoryType.Memory,
                _ => null,
            };
        }
    }
}