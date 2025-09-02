
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: text_editor_code_execution_view_result
    /// </summary>
    public enum BetaResponseTextEditorCodeExecutionViewResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionViewResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextEditorCodeExecutionViewResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextEditorCodeExecutionViewResultBlockType value)
        {
            return value switch
            {
                BetaResponseTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult => "text_editor_code_execution_view_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextEditorCodeExecutionViewResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_view_result" => BetaResponseTextEditorCodeExecutionViewResultBlockType.TextEditorCodeExecutionViewResult,
                _ => null,
            };
        }
    }
}