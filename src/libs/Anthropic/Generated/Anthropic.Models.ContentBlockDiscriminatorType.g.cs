
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
    public static class ContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                ContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                ContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                ContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                ContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                ContentBlockDiscriminatorType.Text => "text",
                ContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                ContentBlockDiscriminatorType.Thinking => "thinking",
                ContentBlockDiscriminatorType.ToolSearchToolResult => "tool_search_tool_result",
                ContentBlockDiscriminatorType.ToolUse => "tool_use",
                ContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
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
                "bash_code_execution_tool_result" => ContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => ContentBlockDiscriminatorType.CodeExecutionToolResult,
                "container_upload" => ContentBlockDiscriminatorType.ContainerUpload,
                "redacted_thinking" => ContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => ContentBlockDiscriminatorType.ServerToolUse,
                "text" => ContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => ContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => ContentBlockDiscriminatorType.Thinking,
                "tool_search_tool_result" => ContentBlockDiscriminatorType.ToolSearchToolResult,
                "tool_use" => ContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => ContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => ContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}