
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchToolResultErrorCode
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
    public static class WebSearchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolResultErrorCode value)
        {
            return value switch
            {
                WebSearchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                WebSearchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                WebSearchToolResultErrorCode.QueryTooLong => "query_too_long",
                WebSearchToolResultErrorCode.RequestTooLarge => "request_too_large",
                WebSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                WebSearchToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => WebSearchToolResultErrorCode.InvalidToolInput,
                "max_uses_exceeded" => WebSearchToolResultErrorCode.MaxUsesExceeded,
                "query_too_long" => WebSearchToolResultErrorCode.QueryTooLong,
                "request_too_large" => WebSearchToolResultErrorCode.RequestTooLarge,
                "too_many_requests" => WebSearchToolResultErrorCode.TooManyRequests,
                "unavailable" => WebSearchToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}