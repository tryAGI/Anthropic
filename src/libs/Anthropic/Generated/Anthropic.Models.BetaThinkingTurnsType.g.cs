
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaThinkingTurnsType
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkingTurns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaThinkingTurnsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingTurnsType value)
        {
            return value switch
            {
                BetaThinkingTurnsType.ThinkingTurns => "thinking_turns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingTurnsType? ToEnum(string value)
        {
            return value switch
            {
                "thinking_turns" => BetaThinkingTurnsType.ThinkingTurns,
                _ => null,
            };
        }
    }
}