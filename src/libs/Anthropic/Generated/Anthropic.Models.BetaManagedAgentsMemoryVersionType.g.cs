
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryVersionType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryVersionType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryVersionType.MemoryVersion => "memory_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryVersionType? ToEnum(string value)
        {
            return value switch
            {
                "memory_version" => BetaManagedAgentsMemoryVersionType.MemoryVersion,
                _ => null,
            };
        }
    }
}