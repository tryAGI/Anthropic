
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaDreamType
    {
        /// <summary>
        /// 
        /// </summary>
        Dream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDreamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamType value)
        {
            return value switch
            {
                BetaDreamType.Dream => "dream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamType? ToEnum(string value)
        {
            return value switch
            {
                "dream" => BetaDreamType.Dream,
                _ => null,
            };
        }
    }
}