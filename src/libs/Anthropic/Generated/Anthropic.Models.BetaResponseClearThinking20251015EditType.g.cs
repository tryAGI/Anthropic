
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of context management edit applied.<br/>
    /// Default Value: clear_thinking_20251015
    /// </summary>
    public enum BetaResponseClearThinking20251015EditType
    {
        /// <summary>
        /// 
        /// </summary>
        ClearThinking20251015,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseClearThinking20251015EditTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseClearThinking20251015EditType value)
        {
            return value switch
            {
                BetaResponseClearThinking20251015EditType.ClearThinking20251015 => "clear_thinking_20251015",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseClearThinking20251015EditType? ToEnum(string value)
        {
            return value switch
            {
                "clear_thinking_20251015" => BetaResponseClearThinking20251015EditType.ClearThinking20251015,
                _ => null,
            };
        }
    }
}