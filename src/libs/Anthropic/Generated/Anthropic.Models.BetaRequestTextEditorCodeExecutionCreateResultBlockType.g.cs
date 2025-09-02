
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionCreateResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionCreateResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionCreateResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionCreateResultBlockType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult => "text_editor_code_execution_create_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionCreateResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_create_result" => BetaRequestTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult,
                _ => null,
            };
        }
    }
}