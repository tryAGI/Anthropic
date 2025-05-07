
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: server_tool_use
    /// </summary>
    public enum ResponseServerToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseServerToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseServerToolUseBlockType value)
        {
            return value switch
            {
                ResponseServerToolUseBlockType.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseServerToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => ResponseServerToolUseBlockType.ServerToolUse,
                _ => null,
            };
        }
    }
}