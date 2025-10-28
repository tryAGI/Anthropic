
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaAllThinkingTurnsType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAllThinkingTurnsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAllThinkingTurnsType value)
        {
            return value switch
            {
                BetaAllThinkingTurnsType.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAllThinkingTurnsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaAllThinkingTurnsType.All,
                _ => null,
            };
        }
    }
}