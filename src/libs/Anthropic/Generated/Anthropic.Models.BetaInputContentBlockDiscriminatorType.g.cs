
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaInputContentBlockDiscriminatorType
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
    public static class BetaInputContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaInputContentBlockDiscriminatorType.Document => "document",
                BetaInputContentBlockDiscriminatorType.Image => "image",
                BetaInputContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaInputContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                BetaInputContentBlockDiscriminatorType.Text => "text",
                BetaInputContentBlockDiscriminatorType.Thinking => "thinking",
                BetaInputContentBlockDiscriminatorType.ToolResult => "tool_result",
                BetaInputContentBlockDiscriminatorType.ToolUse => "tool_use",
                BetaInputContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaInputContentBlockDiscriminatorType.Document,
                "image" => BetaInputContentBlockDiscriminatorType.Image,
                "redacted_thinking" => BetaInputContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => BetaInputContentBlockDiscriminatorType.ServerToolUse,
                "text" => BetaInputContentBlockDiscriminatorType.Text,
                "thinking" => BetaInputContentBlockDiscriminatorType.Thinking,
                "tool_result" => BetaInputContentBlockDiscriminatorType.ToolResult,
                "tool_use" => BetaInputContentBlockDiscriminatorType.ToolUse,
                "web_search_tool_result" => BetaInputContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}