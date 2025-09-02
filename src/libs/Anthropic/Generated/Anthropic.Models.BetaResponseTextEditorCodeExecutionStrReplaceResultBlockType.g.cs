
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: text_editor_code_execution_str_replace_result
    /// </summary>
    public enum BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionStrReplaceResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextEditorCodeExecutionStrReplaceResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType value)
        {
            return value switch
            {
                BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult => "text_editor_code_execution_str_replace_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_str_replace_result" => BetaResponseTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult,
                _ => null,
            };
        }
    }
}