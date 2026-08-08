
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamInputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MemoryStore,
        /// <summary>
        /// 
        /// </summary>
        Sessions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamInputDiscriminatorType value)
        {
            return value switch
            {
                BetaDreamInputDiscriminatorType.MemoryStore => "memory_store",
                BetaDreamInputDiscriminatorType.Sessions => "sessions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "memory_store" => BetaDreamInputDiscriminatorType.MemoryStore,
                "sessions" => BetaDreamInputDiscriminatorType.Sessions,
                _ => null,
            };
        }
    }
}