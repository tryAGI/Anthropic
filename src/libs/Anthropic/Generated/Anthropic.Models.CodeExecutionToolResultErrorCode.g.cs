
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeExecutionToolResultErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                CodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                CodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                CodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                CodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => CodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => CodeExecutionToolResultErrorCode.InvalidToolInput,
                "too_many_requests" => CodeExecutionToolResultErrorCode.TooManyRequests,
                "unavailable" => CodeExecutionToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}