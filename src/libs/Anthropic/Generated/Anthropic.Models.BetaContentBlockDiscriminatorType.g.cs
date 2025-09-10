
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
        BashCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        ContainerUpload,
        /// <summary>
        /// 
        /// </summary>
        McpToolResult,
        /// <summary>
        /// 
        /// </summary>
        McpToolUse,
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
        TextEditorCodeExecutionToolResult,
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
        WebFetchToolResult,
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
                BetaContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                BetaContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                BetaContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                BetaContentBlockDiscriminatorType.McpToolResult => "mcp_tool_result",
                BetaContentBlockDiscriminatorType.McpToolUse => "mcp_tool_use",
                BetaContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                BetaContentBlockDiscriminatorType.Text => "text",
                BetaContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                BetaContentBlockDiscriminatorType.Thinking => "thinking",
                BetaContentBlockDiscriminatorType.ToolUse => "tool_use",
                BetaContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
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
                "bash_code_execution_tool_result" => BetaContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => BetaContentBlockDiscriminatorType.CodeExecutionToolResult,
                "container_upload" => BetaContentBlockDiscriminatorType.ContainerUpload,
                "mcp_tool_result" => BetaContentBlockDiscriminatorType.McpToolResult,
                "mcp_tool_use" => BetaContentBlockDiscriminatorType.McpToolUse,
                "redacted_thinking" => BetaContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => BetaContentBlockDiscriminatorType.ServerToolUse,
                "text" => BetaContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => BetaContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => BetaContentBlockDiscriminatorType.Thinking,
                "tool_use" => BetaContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => BetaContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => BetaContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}