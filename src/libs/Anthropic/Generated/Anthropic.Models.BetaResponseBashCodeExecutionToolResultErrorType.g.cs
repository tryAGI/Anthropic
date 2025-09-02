
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default Value: bash_code_execution_tool_result_error
    /// </summary>
    public enum BetaResponseBashCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseBashCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseBashCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                BetaResponseBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError => "bash_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseBashCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result_error" => BetaResponseBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}