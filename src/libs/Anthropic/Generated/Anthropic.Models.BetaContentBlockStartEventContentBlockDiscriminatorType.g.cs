
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockStartEventContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AdvisorToolResult,
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
        Compaction,
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
        ToolSearchToolResult,
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
    public static class BetaContentBlockStartEventContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockStartEventContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockStartEventContentBlockDiscriminatorType.AdvisorToolResult => "advisor_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.Compaction => "compaction",
                BetaContentBlockStartEventContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                BetaContentBlockStartEventContentBlockDiscriminatorType.McpToolResult => "mcp_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.McpToolUse => "mcp_tool_use",
                BetaContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                BetaContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                BetaContentBlockStartEventContentBlockDiscriminatorType.Text => "text",
                BetaContentBlockStartEventContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.Thinking => "thinking",
                BetaContentBlockStartEventContentBlockDiscriminatorType.ToolSearchToolResult => "tool_search_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.ToolUse => "tool_use",
                BetaContentBlockStartEventContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
                BetaContentBlockStartEventContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockStartEventContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "advisor_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.AdvisorToolResult,
                "bash_code_execution_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.CodeExecutionToolResult,
                "compaction" => BetaContentBlockStartEventContentBlockDiscriminatorType.Compaction,
                "container_upload" => BetaContentBlockStartEventContentBlockDiscriminatorType.ContainerUpload,
                "mcp_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.McpToolResult,
                "mcp_tool_use" => BetaContentBlockStartEventContentBlockDiscriminatorType.McpToolUse,
                "redacted_thinking" => BetaContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => BetaContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse,
                "text" => BetaContentBlockStartEventContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => BetaContentBlockStartEventContentBlockDiscriminatorType.Thinking,
                "tool_search_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.ToolSearchToolResult,
                "tool_use" => BetaContentBlockStartEventContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => BetaContentBlockStartEventContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}