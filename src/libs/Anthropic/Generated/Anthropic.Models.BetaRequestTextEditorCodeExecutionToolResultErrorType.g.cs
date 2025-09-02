
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestTextEditorCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestTextEditorCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestTextEditorCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                BetaRequestTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError => "text_editor_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestTextEditorCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result_error" => BetaRequestTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}