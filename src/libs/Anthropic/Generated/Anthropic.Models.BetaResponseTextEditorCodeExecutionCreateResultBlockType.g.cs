
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: text_editor_code_execution_create_result
    /// </summary>
    public enum BetaResponseTextEditorCodeExecutionCreateResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionCreateResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextEditorCodeExecutionCreateResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextEditorCodeExecutionCreateResultBlockType value)
        {
            return value switch
            {
                BetaResponseTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult => "text_editor_code_execution_create_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextEditorCodeExecutionCreateResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_create_result" => BetaResponseTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult,
                _ => null,
            };
        }
    }
}