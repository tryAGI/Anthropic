
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
    public static class BetaToolSearchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchToolResultErrorCode value)
        {
            return value switch
            {
                BetaToolSearchToolResultErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                BetaToolSearchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaToolSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaToolSearchToolResultErrorCode.Unavailable => "unavailable",
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
                "execution_time_exceeded" => BetaToolSearchToolResultErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => BetaToolSearchToolResultErrorCode.InvalidToolInput,
                "too_many_requests" => BetaToolSearchToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaToolSearchToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}