
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebFetchToolResultErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        UrlTooLong,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAccessible,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedContentType,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchToolResultErrorCode value)
        {
            return value switch
            {
                WebFetchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                WebFetchToolResultErrorCode.UrlTooLong => "url_too_long",
                WebFetchToolResultErrorCode.UrlNotAllowed => "url_not_allowed",
                WebFetchToolResultErrorCode.UrlNotAccessible => "url_not_accessible",
                WebFetchToolResultErrorCode.UnsupportedContentType => "unsupported_content_type",
                WebFetchToolResultErrorCode.TooManyRequests => "too_many_requests",
                WebFetchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                WebFetchToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => WebFetchToolResultErrorCode.InvalidToolInput,
                "url_too_long" => WebFetchToolResultErrorCode.UrlTooLong,
                "url_not_allowed" => WebFetchToolResultErrorCode.UrlNotAllowed,
                "url_not_accessible" => WebFetchToolResultErrorCode.UrlNotAccessible,
                "unsupported_content_type" => WebFetchToolResultErrorCode.UnsupportedContentType,
                "too_many_requests" => WebFetchToolResultErrorCode.TooManyRequests,
                "max_uses_exceeded" => WebFetchToolResultErrorCode.MaxUsesExceeded,
                "unavailable" => WebFetchToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}