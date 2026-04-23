
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStoreDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType.MemoryStoreDeleted => "memory_store_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store_deleted" => BetaManagedAgentsDeleteMemoryStoreResponseDiscriminatorType.MemoryStoreDeleted,
                _ => null,
            };
        }
    }
}