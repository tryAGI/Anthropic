
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCodeExecutionToolResultErrorCode
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
    public static class BetaCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BetaCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeExecutionToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => BetaCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => BetaCodeExecutionToolResultErrorCode.InvalidToolInput,
                "too_many_requests" => BetaCodeExecutionToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaCodeExecutionToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}