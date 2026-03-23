
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
        ApiError,
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        BillingError,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequestError,
        /// <summary>
        /// 
        /// </summary>
        NotFoundError,
        /// <summary>
        /// 
        /// </summary>
        OverloadedError,
        /// <summary>
        /// 
        /// </summary>
        PermissionError,
        /// <summary>
        /// 
        /// </summary>
        RateLimitError,
        /// <summary>
        /// 
        /// </summary>
        TimeoutError,
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
                ErrorType.ApiError => "api_error",
                ErrorType.AuthenticationError => "authentication_error",
                ErrorType.BillingError => "billing_error",
                ErrorType.InvalidRequestError => "invalid_request_error",
                ErrorType.NotFoundError => "not_found_error",
                ErrorType.OverloadedError => "overloaded_error",
                ErrorType.PermissionError => "permission_error",
                ErrorType.RateLimitError => "rate_limit_error",
                ErrorType.TimeoutError => "timeout_error",
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
                "api_error" => ErrorType.ApiError,
                "authentication_error" => ErrorType.AuthenticationError,
                "billing_error" => ErrorType.BillingError,
                "invalid_request_error" => ErrorType.InvalidRequestError,
                "not_found_error" => ErrorType.NotFoundError,
                "overloaded_error" => ErrorType.OverloadedError,
                "permission_error" => ErrorType.PermissionError,
                "rate_limit_error" => ErrorType.RateLimitError,
                "timeout_error" => ErrorType.TimeoutError,
                _ => null,
            };
        }
    }
}