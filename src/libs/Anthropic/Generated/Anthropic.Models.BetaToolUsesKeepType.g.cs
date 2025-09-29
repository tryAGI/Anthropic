
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolUsesKeepType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolUsesKeepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolUsesKeepType value)
        {
            return value switch
            {
                BetaToolUsesKeepType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolUsesKeepType? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => BetaToolUsesKeepType.ToolUses,
                _ => null,
            };
        }
    }
}