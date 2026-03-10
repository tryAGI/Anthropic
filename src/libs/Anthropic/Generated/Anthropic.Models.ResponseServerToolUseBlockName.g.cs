
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseServerToolUseBlockName
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
    public static class ResponseServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseServerToolUseBlockName value)
        {
            return value switch
            {
                ResponseServerToolUseBlockName.WebSearch => "web_search",
                ResponseServerToolUseBlockName.WebFetch => "web_fetch",
                ResponseServerToolUseBlockName.CodeExecution => "code_execution",
                ResponseServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                ResponseServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
                ResponseServerToolUseBlockName.ToolSearchToolRegex => "tool_search_tool_regex",
                ResponseServerToolUseBlockName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseServerToolUseBlockName? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => ResponseServerToolUseBlockName.WebSearch,
                "web_fetch" => ResponseServerToolUseBlockName.WebFetch,
                "code_execution" => ResponseServerToolUseBlockName.CodeExecution,
                "bash_code_execution" => ResponseServerToolUseBlockName.BashCodeExecution,
                "text_editor_code_execution" => ResponseServerToolUseBlockName.TextEditorCodeExecution,
                "tool_search_tool_regex" => ResponseServerToolUseBlockName.ToolSearchToolRegex,
                "tool_search_tool_bm25" => ResponseServerToolUseBlockName.ToolSearchToolBm25,
                _ => null,
            };
        }
    }
}