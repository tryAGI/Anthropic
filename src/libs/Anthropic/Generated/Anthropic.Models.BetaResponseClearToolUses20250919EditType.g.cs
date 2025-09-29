
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of context management edit applied.<br/>
    /// Default Value: clear_tool_uses_20250919
    /// </summary>
    public enum BetaResponseClearToolUses20250919EditType
    {
        /// <summary>
        /// 
        /// </summary>
        ClearToolUses20250919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseClearToolUses20250919EditTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseClearToolUses20250919EditType value)
        {
            return value switch
            {
                BetaResponseClearToolUses20250919EditType.ClearToolUses20250919 => "clear_tool_uses_20250919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseClearToolUses20250919EditType? ToEnum(string value)
        {
            return value switch
            {
                "clear_tool_uses_20250919" => BetaResponseClearToolUses20250919EditType.ClearToolUses20250919,
                _ => null,
            };
        }
    }
}