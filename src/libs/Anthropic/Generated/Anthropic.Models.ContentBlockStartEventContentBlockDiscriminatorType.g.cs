
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentBlockStartEventContentBlockDiscriminatorType
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
    public static class ContentBlockStartEventContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockStartEventContentBlockDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                ContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                ContentBlockStartEventContentBlockDiscriminatorType.Text => "text",
                ContentBlockStartEventContentBlockDiscriminatorType.Thinking => "thinking",
                ContentBlockStartEventContentBlockDiscriminatorType.ToolUse => "tool_use",
                ContentBlockStartEventContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockStartEventContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => ContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse,
                "text" => ContentBlockStartEventContentBlockDiscriminatorType.Text,
                "thinking" => ContentBlockStartEventContentBlockDiscriminatorType.Thinking,
                "tool_use" => ContentBlockStartEventContentBlockDiscriminatorType.ToolUse,
                "web_search_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}