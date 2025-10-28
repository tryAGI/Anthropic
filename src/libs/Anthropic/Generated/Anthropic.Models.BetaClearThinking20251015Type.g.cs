
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaClearThinking20251015Type
    {
        /// <summary>
        /// 
        /// </summary>
        ClearThinking20251015,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClearThinking20251015TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClearThinking20251015Type value)
        {
            return value switch
            {
                BetaClearThinking20251015Type.ClearThinking20251015 => "clear_thinking_20251015",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClearThinking20251015Type? ToEnum(string value)
        {
            return value switch
            {
                "clear_thinking_20251015" => BetaClearThinking20251015Type.ClearThinking20251015,
                _ => null,
            };
        }
    }
}