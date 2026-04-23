
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeletedMemoryStoreType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStoreDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeletedMemoryStoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeletedMemoryStoreType value)
        {
            return value switch
            {
                BetaManagedAgentsDeletedMemoryStoreType.MemoryStoreDeleted => "memory_store_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeletedMemoryStoreType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store_deleted" => BetaManagedAgentsDeletedMemoryStoreType.MemoryStoreDeleted,
                _ => null,
            };
        }
    }
}