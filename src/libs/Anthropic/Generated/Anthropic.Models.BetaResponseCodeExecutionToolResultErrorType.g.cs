
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: code_execution_tool_result_error
    /// </summary>
    public enum BetaResponseCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                BetaResponseCodeExecutionToolResultErrorType.CodeExecutionToolResultError => "code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result_error" => BetaResponseCodeExecutionToolResultErrorType.CodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}