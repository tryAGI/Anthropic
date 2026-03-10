
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BashCodeExecutionToolResultErrorCode
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
        /// <summary>
        /// 
        /// </summary>
        OutputFileTooLarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BashCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BashCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                BashCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BashCodeExecutionToolResultErrorCode.OutputFileTooLarge => "output_file_too_large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashCodeExecutionToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BashCodeExecutionToolResultErrorCode.InvalidToolInput,
                "unavailable" => BashCodeExecutionToolResultErrorCode.Unavailable,
                "too_many_requests" => BashCodeExecutionToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => BashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "output_file_too_large" => BashCodeExecutionToolResultErrorCode.OutputFileTooLarge,
                _ => null,
            };
        }
    }
}