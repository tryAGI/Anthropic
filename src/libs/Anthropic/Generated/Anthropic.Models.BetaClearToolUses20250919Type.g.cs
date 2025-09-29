
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaClearToolUses20250919Type
    {
        /// <summary>
        /// 
        /// </summary>
        ClearToolUses20250919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClearToolUses20250919TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClearToolUses20250919Type value)
        {
            return value switch
            {
                BetaClearToolUses20250919Type.ClearToolUses20250919 => "clear_tool_uses_20250919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClearToolUses20250919Type? ToEnum(string value)
        {
            return value switch
            {
                "clear_tool_uses_20250919" => BetaClearToolUses20250919Type.ClearToolUses20250919,
                _ => null,
            };
        }
    }
}