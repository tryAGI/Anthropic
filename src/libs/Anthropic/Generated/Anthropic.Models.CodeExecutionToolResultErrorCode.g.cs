
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
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
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
                CodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                CodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                CodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                CodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
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
                "invalid_tool_input" => CodeExecutionToolResultErrorCode.InvalidToolInput,
                "unavailable" => CodeExecutionToolResultErrorCode.Unavailable,
                "too_many_requests" => CodeExecutionToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => CodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                _ => null,
            };
        }
    }
}