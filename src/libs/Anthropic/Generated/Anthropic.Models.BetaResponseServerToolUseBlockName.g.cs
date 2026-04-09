
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaResponseServerToolUseBlockName
    {
        /// <summary>
        /// 
        /// </summary>
        Advisor,
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
    public static class BetaResponseServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseServerToolUseBlockName value)
        {
            return value switch
            {
                BetaResponseServerToolUseBlockName.Advisor => "advisor",
                BetaResponseServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                BetaResponseServerToolUseBlockName.CodeExecution => "code_execution",
                BetaResponseServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
                BetaResponseServerToolUseBlockName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                BetaResponseServerToolUseBlockName.ToolSearchToolRegex => "tool_search_tool_regex",
                BetaResponseServerToolUseBlockName.WebFetch => "web_fetch",
                BetaResponseServerToolUseBlockName.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseServerToolUseBlockName? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => BetaResponseServerToolUseBlockName.Advisor,
                "bash_code_execution" => BetaResponseServerToolUseBlockName.BashCodeExecution,
                "code_execution" => BetaResponseServerToolUseBlockName.CodeExecution,
                "text_editor_code_execution" => BetaResponseServerToolUseBlockName.TextEditorCodeExecution,
                "tool_search_tool_bm25" => BetaResponseServerToolUseBlockName.ToolSearchToolBm25,
                "tool_search_tool_regex" => BetaResponseServerToolUseBlockName.ToolSearchToolRegex,
                "web_fetch" => BetaResponseServerToolUseBlockName.WebFetch,
                "web_search" => BetaResponseServerToolUseBlockName.WebSearch,
                _ => null,
            };
        }
    }
}