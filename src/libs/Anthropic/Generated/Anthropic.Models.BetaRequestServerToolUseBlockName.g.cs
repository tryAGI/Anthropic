
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
                BetaRequestServerToolUseBlockName.WebSearch => "web_search",
                BetaRequestServerToolUseBlockName.WebFetch => "web_fetch",
                BetaRequestServerToolUseBlockName.CodeExecution => "code_execution",
                BetaRequestServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                BetaRequestServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
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
                "web_search" => BetaRequestServerToolUseBlockName.WebSearch,
                "web_fetch" => BetaRequestServerToolUseBlockName.WebFetch,
                "code_execution" => BetaRequestServerToolUseBlockName.CodeExecution,
                "bash_code_execution" => BetaRequestServerToolUseBlockName.BashCodeExecution,
                "text_editor_code_execution" => BetaRequestServerToolUseBlockName.TextEditorCodeExecution,
                _ => null,
            };
        }
    }
}