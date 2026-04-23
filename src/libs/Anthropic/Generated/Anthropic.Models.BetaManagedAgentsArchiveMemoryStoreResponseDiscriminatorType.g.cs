
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaManagedAgentsArchiveMemoryStoreResponseDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}