
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                BetaRequestCodeExecutionToolResultErrorType.CodeExecutionToolResultError => "code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result_error" => BetaRequestCodeExecutionToolResultErrorType.CodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}