
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestBashCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestBashCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestBashCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                BetaRequestBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError => "bash_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestBashCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result_error" => BetaRequestBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}