
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
                WebSearchToolResultErrorCode.Unavailable => "unavailable",
                WebSearchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                WebSearchToolResultErrorCode.TooManyRequests => "too_many_requests",
                WebSearchToolResultErrorCode.QueryTooLong => "query_too_long",
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
                "unavailable" => WebSearchToolResultErrorCode.Unavailable,
                "max_uses_exceeded" => WebSearchToolResultErrorCode.MaxUsesExceeded,
                "too_many_requests" => WebSearchToolResultErrorCode.TooManyRequests,
                "query_too_long" => WebSearchToolResultErrorCode.QueryTooLong,
                _ => null,
            };
        }
    }
}