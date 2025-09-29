
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolUsesTriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolUsesTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolUsesTriggerType value)
        {
            return value switch
            {
                BetaToolUsesTriggerType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolUsesTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => BetaToolUsesTriggerType.ToolUses,
                _ => null,
            };
        }
    }
}