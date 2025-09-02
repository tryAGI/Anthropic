
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionStrReplaceResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionStrReplaceResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult => "text_editor_code_execution_str_replace_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_str_replace_result" => BetaRequestTextEditorCodeExecutionStrReplaceResultBlockType.TextEditorCodeExecutionStrReplaceResult,
                _ => null,
            };
        }
    }
}