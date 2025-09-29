
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaClearToolUses20250919KeepDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClearToolUses20250919KeepDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClearToolUses20250919KeepDiscriminatorType value)
        {
            return value switch
            {
                BetaClearToolUses20250919KeepDiscriminatorType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClearToolUses20250919KeepDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => BetaClearToolUses20250919KeepDiscriminatorType.ToolUses,
                _ => null,
            };
        }
    }
}