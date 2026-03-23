
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
                BetaWebFetchToolResultErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                BetaWebFetchToolResultErrorCode.TooManyRequests => "too_many_requests",
                BetaWebFetchToolResultErrorCode.Unavailable => "unavailable",
                BetaWebFetchToolResultErrorCode.UnsupportedContentType => "unsupported_content_type",
                BetaWebFetchToolResultErrorCode.UrlNotAccessible => "url_not_accessible",
                BetaWebFetchToolResultErrorCode.UrlNotAllowed => "url_not_allowed",
                BetaWebFetchToolResultErrorCode.UrlTooLong => "url_too_long",
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
                "max_uses_exceeded" => BetaWebFetchToolResultErrorCode.MaxUsesExceeded,
                "too_many_requests" => BetaWebFetchToolResultErrorCode.TooManyRequests,
                "unavailable" => BetaWebFetchToolResultErrorCode.Unavailable,
                "unsupported_content_type" => BetaWebFetchToolResultErrorCode.UnsupportedContentType,
                "url_not_accessible" => BetaWebFetchToolResultErrorCode.UrlNotAccessible,
                "url_not_allowed" => BetaWebFetchToolResultErrorCode.UrlNotAllowed,
                "url_too_long" => BetaWebFetchToolResultErrorCode.UrlTooLong,
                _ => null,
            };
        }
    }
}