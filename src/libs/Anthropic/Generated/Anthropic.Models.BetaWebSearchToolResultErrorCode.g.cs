
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
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        QueryTooLong,
        /// <summary>
        /// 
        /// </summary>
        RequestTooLarge,
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
                BetaWebSearchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BetaWebSearchToolResultErrorCode.QueryTooLong => "query_too_long",
                BetaWebSearchToolResultErrorCode.RequestTooLarge => "request_too_large",
                BetaWebSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaWebSearchToolResultErrorCode.Unavailable => "unavailable",
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
                "max_uses_exceeded" => BetaWebSearchToolResultErrorCode.MaxUsesExceeded,
                "query_too_long" => BetaWebSearchToolResultErrorCode.QueryTooLong,
                "request_too_large" => BetaWebSearchToolResultErrorCode.RequestTooLarge,
                "too_many_requests" => BetaWebSearchToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaWebSearchToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}