
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebSearchToolResultErrorCode
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
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        QueryTooLong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchToolResultErrorCode value)
        {
            return value switch
            {
                BetaWebSearchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaWebSearchToolResultErrorCode.Unavailable => "unavailable",
                BetaWebSearchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BetaWebSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaWebSearchToolResultErrorCode.QueryTooLong => "query_too_long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BetaWebSearchToolResultErrorCode.InvalidToolInput,
                "unavailable" => BetaWebSearchToolResultErrorCode.Unavailable,
                "max_uses_exceeded" => BetaWebSearchToolResultErrorCode.MaxUsesExceeded,
                "too_many_requests" => BetaWebSearchToolResultErrorCode.TooManyRequests,
                "query_too_long" => BetaWebSearchToolResultErrorCode.QueryTooLong,
                _ => null,
            };
        }
    }
}