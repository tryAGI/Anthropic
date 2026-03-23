
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
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        OutputFileTooLarge,
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
    public static class BashCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BashCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BashCodeExecutionToolResultErrorCode.OutputFileTooLarge => "output_file_too_large",
                BashCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BashCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
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
                "execution_time_exceeded" => BashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => BashCodeExecutionToolResultErrorCode.InvalidToolInput,
                "output_file_too_large" => BashCodeExecutionToolResultErrorCode.OutputFileTooLarge,
                "too_many_requests" => BashCodeExecutionToolResultErrorCode.TooManyRequests,
                "unavailable" => BashCodeExecutionToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}