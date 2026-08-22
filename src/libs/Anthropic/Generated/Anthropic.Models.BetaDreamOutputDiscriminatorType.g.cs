
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamOutputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamOutputDiscriminatorType value)
        {
            return value switch
            {
                BetaDreamOutputDiscriminatorType.MemoryStore => "memory_store",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaDreamOutputDiscriminatorType.MemoryStore,
                _ => null,
            };
        }
    }
}