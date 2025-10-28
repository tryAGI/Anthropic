
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaClearThinking20251015KeepDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        ThinkingTurns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClearThinking20251015KeepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClearThinking20251015KeepDiscriminatorType value)
        {
            return value switch
            {
                BetaClearThinking20251015KeepDiscriminatorType.All => "all",
                BetaClearThinking20251015KeepDiscriminatorType.ThinkingTurns => "thinking_turns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClearThinking20251015KeepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaClearThinking20251015KeepDiscriminatorType.All,
                "thinking_turns" => BetaClearThinking20251015KeepDiscriminatorType.ThinkingTurns,
                _ => null,
            };
        }
    }
}