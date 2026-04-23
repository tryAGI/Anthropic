
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeletedMemoryType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeletedMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeletedMemoryType value)
        {
            return value switch
            {
                BetaManagedAgentsDeletedMemoryType.MemoryDeleted => "memory_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeletedMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "memory_deleted" => BetaManagedAgentsDeletedMemoryType.MemoryDeleted,
                _ => null,
            };
        }
    }
}