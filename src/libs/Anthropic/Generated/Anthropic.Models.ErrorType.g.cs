
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidRequestError,
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        PermissionError,
        /// <summary>
        /// 
        /// </summary>
        NotFoundError,
        /// <summary>
        /// 
        /// </summary>
        RateLimitError,
        /// <summary>
        /// 
        /// </summary>
        TimeoutError,
        /// <summary>
        /// 
        /// </summary>
        OverloadedError,
        /// <summary>
        /// 
        /// </summary>
        ApiError,
        /// <summary>
        /// 
        /// </summary>
        BillingError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorType value)
        {
            return value switch
            {
                ErrorType.InvalidRequestError => "invalid_request_error",
                ErrorType.AuthenticationError => "authentication_error",
                ErrorType.PermissionError => "permission_error",
                ErrorType.NotFoundError => "not_found_error",
                ErrorType.RateLimitError => "rate_limit_error",
                ErrorType.TimeoutError => "timeout_error",
                ErrorType.OverloadedError => "overloaded_error",
                ErrorType.ApiError => "api_error",
                ErrorType.BillingError => "billing_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_request_error" => ErrorType.InvalidRequestError,
                "authentication_error" => ErrorType.AuthenticationError,
                "permission_error" => ErrorType.PermissionError,
                "not_found_error" => ErrorType.NotFoundError,
                "rate_limit_error" => ErrorType.RateLimitError,
                "timeout_error" => ErrorType.TimeoutError,
                "overloaded_error" => ErrorType.OverloadedError,
                "api_error" => ErrorType.ApiError,
                "billing_error" => ErrorType.BillingError,
                _ => null,
            };
        }
    }
}