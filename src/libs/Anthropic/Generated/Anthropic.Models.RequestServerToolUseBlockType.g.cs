
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestServerToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestServerToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestServerToolUseBlockType value)
        {
            return value switch
            {
                RequestServerToolUseBlockType.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestServerToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => RequestServerToolUseBlockType.ServerToolUse,
                _ => null,
            };
        }
    }
}