
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of content block.<br/>
    /// Default Value: tool_result
    /// </summary>
    public enum ToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolResultBlockType value)
        {
            return value switch
            {
                ToolResultBlockType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => ToolResultBlockType.ToolResult,
                _ => null,
            };
        }
    }
}