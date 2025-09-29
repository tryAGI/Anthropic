
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaClearToolUses20250919TriggerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClearToolUses20250919TriggerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClearToolUses20250919TriggerDiscriminatorType value)
        {
            return value switch
            {
                BetaClearToolUses20250919TriggerDiscriminatorType.InputTokens => "input_tokens",
                BetaClearToolUses20250919TriggerDiscriminatorType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClearToolUses20250919TriggerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => BetaClearToolUses20250919TriggerDiscriminatorType.InputTokens,
                "tool_uses" => BetaClearToolUses20250919TriggerDiscriminatorType.ToolUses,
                _ => null,
            };
        }
    }
}