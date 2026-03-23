
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBashCodeExecutionToolResultErrorCode
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
    public static class BetaBashCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBashCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BetaBashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaBashCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaBashCodeExecutionToolResultErrorCode.OutputFileTooLarge => "output_file_too_large",
                BetaBashCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaBashCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBashCodeExecutionToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => BetaBashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => BetaBashCodeExecutionToolResultErrorCode.InvalidToolInput,
                "output_file_too_large" => BetaBashCodeExecutionToolResultErrorCode.OutputFileTooLarge,
                "too_many_requests" => BetaBashCodeExecutionToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaBashCodeExecutionToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}