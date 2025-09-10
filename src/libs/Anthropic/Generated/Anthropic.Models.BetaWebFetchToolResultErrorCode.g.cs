
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaWebFetchToolResultErrorCode
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
    public static class BetaWebFetchToolResultErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebFetchToolResultErrorCode value)
        {
            return value switch
            {
                BetaWebFetchToolResultErrorCode.InvalidToolInput => "invalid_tool_input",
                BetaWebFetchToolResultErrorCode.UrlTooLong => "url_too_long",
                BetaWebFetchToolResultErrorCode.UrlNotAllowed => "url_not_allowed",
                BetaWebFetchToolResultErrorCode.UrlNotAccessible => "url_not_accessible",
                BetaWebFetchToolResultErrorCode.UnsupportedContentType => "unsupported_content_type",
                BetaWebFetchToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaWebFetchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BetaWebFetchToolResultErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebFetchToolResultErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => BetaWebFetchToolResultErrorCode.InvalidToolInput,
                "url_too_long" => BetaWebFetchToolResultErrorCode.UrlTooLong,
                "url_not_allowed" => BetaWebFetchToolResultErrorCode.UrlNotAllowed,
                "url_not_accessible" => BetaWebFetchToolResultErrorCode.UrlNotAccessible,
                "unsupported_content_type" => BetaWebFetchToolResultErrorCode.UnsupportedContentType,
                "too_many_requests" => BetaWebFetchToolResultErrorCode.TooManyRequests,
                "max_uses_exceeded" => BetaWebFetchToolResultErrorCode.MaxUsesExceeded,
                "unavailable" => BetaWebFetchToolResultErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}