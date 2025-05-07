
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: server_tool_use
    /// </summary>
    public enum BetaResponseServerToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseServerToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseServerToolUseBlockType value)
        {
            return value switch
            {
                BetaResponseServerToolUseBlockType.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseServerToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => BetaResponseServerToolUseBlockType.ServerToolUse,
                _ => null,
            };
        }
    }
}