
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
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedContentType,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAccessible,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        UrlTooLong,
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
                WebFetchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                WebFetchToolResultErrorCode.TooManyRequests => "too_many_requests",
                WebFetchToolResultErrorCode.Unavailable => "unavailable",
                WebFetchToolResultErrorCode.UnsupportedContentType => "unsupported_content_type",
                WebFetchToolResultErrorCode.UrlNotAccessible => "url_not_accessible",
                WebFetchToolResultErrorCode.UrlNotAllowed => "url_not_allowed",
                WebFetchToolResultErrorCode.UrlTooLong => "url_too_long",
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
                "max_uses_exceeded" => WebFetchToolResultErrorCode.MaxUsesExceeded,
                "too_many_requests" => WebFetchToolResultErrorCode.TooManyRequests,
                "unavailable" => WebFetchToolResultErrorCode.Unavailable,
                "unsupported_content_type" => WebFetchToolResultErrorCode.UnsupportedContentType,
                "url_not_accessible" => WebFetchToolResultErrorCode.UrlNotAccessible,
                "url_not_allowed" => WebFetchToolResultErrorCode.UrlNotAllowed,
                "url_too_long" => WebFetchToolResultErrorCode.UrlTooLong,
                _ => null,
            };
        }
    }
}