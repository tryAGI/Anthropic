
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
        WebSearch,
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
    public static class BetaResponseServerToolUseBlockNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseServerToolUseBlockName value)
        {
            return value switch
            {
                BetaResponseServerToolUseBlockName.WebSearch => "web_search",
                BetaResponseServerToolUseBlockName.CodeExecution => "code_execution",
                BetaResponseServerToolUseBlockName.BashCodeExecution => "bash_code_execution",
                BetaResponseServerToolUseBlockName.TextEditorCodeExecution => "text_editor_code_execution",
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
                "web_search" => BetaResponseServerToolUseBlockName.WebSearch,
                "code_execution" => BetaResponseServerToolUseBlockName.CodeExecution,
                "bash_code_execution" => BetaResponseServerToolUseBlockName.BashCodeExecution,
                "text_editor_code_execution" => BetaResponseServerToolUseBlockName.TextEditorCodeExecution,
                _ => null,
            };
        }
    }
}