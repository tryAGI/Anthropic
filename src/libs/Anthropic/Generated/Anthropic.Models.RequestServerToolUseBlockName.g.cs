
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestServerToolUseBlockName
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolRegex,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestServerToolUseBlockName value)
        {
            return value switch
            {
                RequestServerToolUseBlockName.WebSearch => "web_search",
                RequestServerToolUseBlockName.WebFetch => "web_fetch",
                RequestServerToolUseBlockName.CodeExecution => "code_execution",
                RequestServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                RequestServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
                RequestServerToolUseBlockName.ToolSearchToolRegex => "tool_search_tool_regex",
                RequestServerToolUseBlockName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestServerToolUseBlockName? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => RequestServerToolUseBlockName.WebSearch,
                "web_fetch" => RequestServerToolUseBlockName.WebFetch,
                "code_execution" => RequestServerToolUseBlockName.CodeExecution,
                "bash_code_execution" => RequestServerToolUseBlockName.BashCodeExecution,
                "text_editor_code_execution" => RequestServerToolUseBlockName.TextEditorCodeExecution,
                "tool_search_tool_regex" => RequestServerToolUseBlockName.ToolSearchToolRegex,
                "tool_search_tool_bm25" => RequestServerToolUseBlockName.ToolSearchToolBm25,
                _ => null,
            };
        }
    }
}