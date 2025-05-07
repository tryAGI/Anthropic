
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
        RedactedThinking,
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
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
                ContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                ContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                ContentBlockDiscriminatorType.Text => "text",
                ContentBlockDiscriminatorType.Thinking => "thinking",
                ContentBlockDiscriminatorType.ToolUse => "tool_use",
                ContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
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
                "redacted_thinking" => ContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => ContentBlockDiscriminatorType.ServerToolUse,
                "text" => ContentBlockDiscriminatorType.Text,
                "thinking" => ContentBlockDiscriminatorType.Thinking,
                "tool_use" => ContentBlockDiscriminatorType.ToolUse,
                "web_search_tool_result" => ContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}