
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
    public static class BetaCodeExecutionToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeExecutionToolResultErrorCode value)
        {
            return value switch
            {
                BetaCodeExecutionToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaCodeExecutionToolResultErrorCode.Unavailable => "unavailable",
                BetaCodeExecutionToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaCodeExecutionToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
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
                "invalid_tool_input" => BetaCodeExecutionToolResultErrorCode.InvalidToolInput,
                "unavailable" => BetaCodeExecutionToolResultErrorCode.Unavailable,
                "too_many_requests" => BetaCodeExecutionToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => BetaCodeExecutionToolResultErrorCode.ExecutionTimeExceeded,
                _ => null,
            };
        }
    }
}