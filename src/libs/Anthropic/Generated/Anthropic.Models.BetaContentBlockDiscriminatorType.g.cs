
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockDiscriminatorType
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
    public static class BetaContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                BetaContentBlockDiscriminatorType.Text => "text",
                BetaContentBlockDiscriminatorType.Thinking => "thinking",
                BetaContentBlockDiscriminatorType.ToolUse => "tool_use",
                BetaContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => BetaContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => BetaContentBlockDiscriminatorType.ServerToolUse,
                "text" => BetaContentBlockDiscriminatorType.Text,
                "thinking" => BetaContentBlockDiscriminatorType.Thinking,
                "tool_use" => BetaContentBlockDiscriminatorType.ToolUse,
                "web_search_tool_result" => BetaContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}