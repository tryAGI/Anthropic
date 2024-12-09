
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockDiscriminatorType.Text => "text",
                ContentBlockDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ContentBlockDiscriminatorType.Text,
                "tool_use" => ContentBlockDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}