
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaManagedAgentsUpdateMemoryStoreResponseDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}