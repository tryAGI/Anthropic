
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaToolSearchToolResultErrorCode
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
    public static class BetaToolSearchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchToolResultErrorCode value)
        {
            return value switch
            {
                BetaToolSearchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaToolSearchToolResultErrorCode.Unavailable => "unavailable",
                BetaToolSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaToolSearchToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BetaToolSearchToolResultErrorCode.InvalidToolInput,
                "unavailable" => BetaToolSearchToolResultErrorCode.Unavailable,
                "too_many_requests" => BetaToolSearchToolResultErrorCode.TooManyRequests,
                "execution_time_exceeded" => BetaToolSearchToolResultErrorCode.ExecutionTimeExceeded,
                _ => null,
            };
        }
    }
}