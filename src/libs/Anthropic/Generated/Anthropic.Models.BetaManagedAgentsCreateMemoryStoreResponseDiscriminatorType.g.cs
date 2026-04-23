
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaManagedAgentsCreateMemoryStoreResponseDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}