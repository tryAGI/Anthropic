
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
    public static class BetaBashCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBashCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BetaBashCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaBashCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                BetaBashCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaBashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaBashCodeExecutionToolResultErrorCode.OutputFileTooLarge => "output_file_too_large",
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
                "invalid_tool_input" => BetaBashCodeExecutionToolResultErrorCode.InvalidToolInput,
                "unavailable" => BetaBashCodeExecutionToolResultErrorCode.Unavailable,
                "too_many_requests" => BetaBashCodeExecutionToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => BetaBashCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "output_file_too_large" => BetaBashCodeExecutionToolResultErrorCode.OutputFileTooLarge,
                _ => null,
            };
        }
    }
}