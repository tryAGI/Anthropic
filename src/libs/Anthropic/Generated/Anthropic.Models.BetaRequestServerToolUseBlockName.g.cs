
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestServerToolUseBlockName
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
    public static class BetaRequestServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestServerToolUseBlockName value)
        {
            return value switch
            {
                BetaRequestServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                BetaRequestServerToolUseBlockName.CodeExecution => "code_execution",
                BetaRequestServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
                BetaRequestServerToolUseBlockName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                BetaRequestServerToolUseBlockName.ToolSearchToolRegex => "tool_search_tool_regex",
                BetaRequestServerToolUseBlockName.WebFetch => "web_fetch",
                BetaRequestServerToolUseBlockName.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestServerToolUseBlockName? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution" => BetaRequestServerToolUseBlockName.BashCodeExecution,
                "code_execution" => BetaRequestServerToolUseBlockName.CodeExecution,
                "text_editor_code_execution" => BetaRequestServerToolUseBlockName.TextEditorCodeExecution,
                "tool_search_tool_bm25" => BetaRequestServerToolUseBlockName.ToolSearchToolBm25,
                "tool_search_tool_regex" => BetaRequestServerToolUseBlockName.ToolSearchToolRegex,
                "web_fetch" => BetaRequestServerToolUseBlockName.WebFetch,
                "web_search" => BetaRequestServerToolUseBlockName.WebSearch,
                _ => null,
            };
        }
    }
}