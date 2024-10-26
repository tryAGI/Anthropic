
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The type of content block.<br/>
    /// Default Value: tool_use
    /// </summary>
    public enum ToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolUseBlockType value)
        {
            return value switch
            {
                ToolUseBlockType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => ToolUseBlockType.ToolUse,
                _ => null,
            };
        }
    }
}