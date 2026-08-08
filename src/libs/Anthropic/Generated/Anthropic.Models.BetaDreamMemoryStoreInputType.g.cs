
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamMemoryStoreInputType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamMemoryStoreInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamMemoryStoreInputType value)
        {
            return value switch
            {
                BetaDreamMemoryStoreInputType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamMemoryStoreInputType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaDreamMemoryStoreInputType.MemoryStore,
                _ => null,
            };
        }
    }
}