
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamMemoryStoreOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamMemoryStoreOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamMemoryStoreOutputType value)
        {
            return value switch
            {
                BetaDreamMemoryStoreOutputType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamMemoryStoreOutputType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaDreamMemoryStoreOutputType.MemoryStore,
                _ => null,
            };
        }
    }
}