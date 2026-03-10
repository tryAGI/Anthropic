
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
    public static class ContentBlockStartEventContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockStartEventContentBlockDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockStartEventContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                ContentBlockStartEventContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                ContentBlockStartEventContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                ContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                ContentBlockStartEventContentBlockDiscriminatorType.Text => "text",
                ContentBlockStartEventContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                ContentBlockStartEventContentBlockDiscriminatorType.Thinking => "thinking",
                ContentBlockStartEventContentBlockDiscriminatorType.ToolSearchToolResult => "tool_search_tool_result",
                ContentBlockStartEventContentBlockDiscriminatorType.ToolUse => "tool_use",
                ContentBlockStartEventContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
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
                "bash_code_execution_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.CodeExecutionToolResult,
                "container_upload" => ContentBlockStartEventContentBlockDiscriminatorType.ContainerUpload,
                "redacted_thinking" => ContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => ContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse,
                "text" => ContentBlockStartEventContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => ContentBlockStartEventContentBlockDiscriminatorType.Thinking,
                "tool_search_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.ToolSearchToolResult,
                "tool_use" => ContentBlockStartEventContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => ContentBlockStartEventContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}