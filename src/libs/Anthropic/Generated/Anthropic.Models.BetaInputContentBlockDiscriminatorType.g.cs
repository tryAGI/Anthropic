
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
        Document,
        /// <summary>
        /// 
        /// </summary>
        Image,
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
        SearchResult,
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
        ToolResult,
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
    public static class BetaInputContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaInputContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                BetaInputContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                BetaInputContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                BetaInputContentBlockDiscriminatorType.Document => "document",
                BetaInputContentBlockDiscriminatorType.Image => "image",
                BetaInputContentBlockDiscriminatorType.McpToolResult => "mcp_tool_result",
                BetaInputContentBlockDiscriminatorType.McpToolUse => "mcp_tool_use",
                BetaInputContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaInputContentBlockDiscriminatorType.SearchResult => "search_result",
                BetaInputContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                BetaInputContentBlockDiscriminatorType.Text => "text",
                BetaInputContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                BetaInputContentBlockDiscriminatorType.Thinking => "thinking",
                BetaInputContentBlockDiscriminatorType.ToolResult => "tool_result",
                BetaInputContentBlockDiscriminatorType.ToolUse => "tool_use",
                BetaInputContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
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
                "bash_code_execution_tool_result" => BetaInputContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => BetaInputContentBlockDiscriminatorType.CodeExecutionToolResult,
                "container_upload" => BetaInputContentBlockDiscriminatorType.ContainerUpload,
                "document" => BetaInputContentBlockDiscriminatorType.Document,
                "image" => BetaInputContentBlockDiscriminatorType.Image,
                "mcp_tool_result" => BetaInputContentBlockDiscriminatorType.McpToolResult,
                "mcp_tool_use" => BetaInputContentBlockDiscriminatorType.McpToolUse,
                "redacted_thinking" => BetaInputContentBlockDiscriminatorType.RedactedThinking,
                "search_result" => BetaInputContentBlockDiscriminatorType.SearchResult,
                "server_tool_use" => BetaInputContentBlockDiscriminatorType.ServerToolUse,
                "text" => BetaInputContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => BetaInputContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => BetaInputContentBlockDiscriminatorType.Thinking,
                "tool_result" => BetaInputContentBlockDiscriminatorType.ToolResult,
                "tool_use" => BetaInputContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => BetaInputContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => BetaInputContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}