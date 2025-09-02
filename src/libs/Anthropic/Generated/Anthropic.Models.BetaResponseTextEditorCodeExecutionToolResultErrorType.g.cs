
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: text_editor_code_execution_tool_result_error
    /// </summary>
    public enum BetaResponseTextEditorCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextEditorCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextEditorCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                BetaResponseTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError => "text_editor_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextEditorCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result_error" => BetaResponseTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}