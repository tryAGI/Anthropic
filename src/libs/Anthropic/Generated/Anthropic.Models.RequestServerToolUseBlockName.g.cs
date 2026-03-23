
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
        BashCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm25,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolRegex,
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
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
                RequestServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                RequestServerToolUseBlockName.CodeExecution => "code_execution",
                RequestServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
                RequestServerToolUseBlockName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                RequestServerToolUseBlockName.ToolSearchToolRegex => "tool_search_tool_regex",
                RequestServerToolUseBlockName.WebFetch => "web_fetch",
                RequestServerToolUseBlockName.WebSearch => "web_search",
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
                "bash_code_execution" => RequestServerToolUseBlockName.BashCodeExecution,
                "code_execution" => RequestServerToolUseBlockName.CodeExecution,
                "text_editor_code_execution" => RequestServerToolUseBlockName.TextEditorCodeExecution,
                "tool_search_tool_bm25" => RequestServerToolUseBlockName.ToolSearchToolBm25,
                "tool_search_tool_regex" => RequestServerToolUseBlockName.ToolSearchToolRegex,
                "web_fetch" => RequestServerToolUseBlockName.WebFetch,
                "web_search" => RequestServerToolUseBlockName.WebSearch,
                _ => null,
            };
        }
    }
}