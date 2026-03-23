
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
    public static class ResponseServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseServerToolUseBlockName value)
        {
            return value switch
            {
                ResponseServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                ResponseServerToolUseBlockName.CodeExecution => "code_execution",
                ResponseServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
                ResponseServerToolUseBlockName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                ResponseServerToolUseBlockName.ToolSearchToolRegex => "tool_search_tool_regex",
                ResponseServerToolUseBlockName.WebFetch => "web_fetch",
                ResponseServerToolUseBlockName.WebSearch => "web_search",
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
                "bash_code_execution" => ResponseServerToolUseBlockName.BashCodeExecution,
                "code_execution" => ResponseServerToolUseBlockName.CodeExecution,
                "text_editor_code_execution" => ResponseServerToolUseBlockName.TextEditorCodeExecution,
                "tool_search_tool_bm25" => ResponseServerToolUseBlockName.ToolSearchToolBm25,
                "tool_search_tool_regex" => ResponseServerToolUseBlockName.ToolSearchToolRegex,
                "web_fetch" => ResponseServerToolUseBlockName.WebFetch,
                "web_search" => ResponseServerToolUseBlockName.WebSearch,
                _ => null,
            };
        }
    }
}