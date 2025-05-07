
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Image,
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
        ToolResult,
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
    public static class InputContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentBlockDiscriminatorType value)
        {
            return value switch
            {
                InputContentBlockDiscriminatorType.Document => "document",
                InputContentBlockDiscriminatorType.Image => "image",
                InputContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                InputContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                InputContentBlockDiscriminatorType.Text => "text",
                InputContentBlockDiscriminatorType.Thinking => "thinking",
                InputContentBlockDiscriminatorType.ToolResult => "tool_result",
                InputContentBlockDiscriminatorType.ToolUse => "tool_use",
                InputContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => InputContentBlockDiscriminatorType.Document,
                "image" => InputContentBlockDiscriminatorType.Image,
                "redacted_thinking" => InputContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => InputContentBlockDiscriminatorType.ServerToolUse,
                "text" => InputContentBlockDiscriminatorType.Text,
                "thinking" => InputContentBlockDiscriminatorType.Thinking,
                "tool_result" => InputContentBlockDiscriminatorType.ToolResult,
                "tool_use" => InputContentBlockDiscriminatorType.ToolUse,
                "web_search_tool_result" => InputContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}