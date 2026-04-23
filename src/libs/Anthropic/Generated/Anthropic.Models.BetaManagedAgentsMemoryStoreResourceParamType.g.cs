
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsMemoryStoreResourceParamType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsMemoryStoreResourceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsMemoryStoreResourceParamType value)
        {
            return value switch
            {
                BetaManagedAgentsMemoryStoreResourceParamType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsMemoryStoreResourceParamType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaManagedAgentsMemoryStoreResourceParamType.MemoryStore,
                _ => null,
            };
        }
    }
}