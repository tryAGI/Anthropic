
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
    public static class InputContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputContentBlockDiscriminatorType value)
        {
            return value switch
            {
                InputContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                InputContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                InputContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                InputContentBlockDiscriminatorType.Document => "document",
                InputContentBlockDiscriminatorType.Image => "image",
                InputContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                InputContentBlockDiscriminatorType.SearchResult => "search_result",
                InputContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                InputContentBlockDiscriminatorType.Text => "text",
                InputContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                InputContentBlockDiscriminatorType.Thinking => "thinking",
                InputContentBlockDiscriminatorType.ToolResult => "tool_result",
                InputContentBlockDiscriminatorType.ToolSearchToolResult => "tool_search_tool_result",
                InputContentBlockDiscriminatorType.ToolUse => "tool_use",
                InputContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
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
                "bash_code_execution_tool_result" => InputContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => InputContentBlockDiscriminatorType.CodeExecutionToolResult,
                "container_upload" => InputContentBlockDiscriminatorType.ContainerUpload,
                "document" => InputContentBlockDiscriminatorType.Document,
                "image" => InputContentBlockDiscriminatorType.Image,
                "redacted_thinking" => InputContentBlockDiscriminatorType.RedactedThinking,
                "search_result" => InputContentBlockDiscriminatorType.SearchResult,
                "server_tool_use" => InputContentBlockDiscriminatorType.ServerToolUse,
                "text" => InputContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => InputContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => InputContentBlockDiscriminatorType.Thinking,
                "tool_result" => InputContentBlockDiscriminatorType.ToolResult,
                "tool_search_tool_result" => InputContentBlockDiscriminatorType.ToolSearchToolResult,
                "tool_use" => InputContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => InputContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => InputContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}