
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryListItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Memory,
        /// <summary>
        /// 
        /// </summary>
        MemoryPrefix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryListItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryListItemDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryListItemDiscriminatorType.Memory => "memory",
                BetaManagedAgentsMemoryListItemDiscriminatorType.MemoryPrefix => "memory_prefix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryListItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory" => BetaManagedAgentsMemoryListItemDiscriminatorType.Memory,
                "memory_prefix" => BetaManagedAgentsMemoryListItemDiscriminatorType.MemoryPrefix,
                _ => null,
            };
        }
    }
}