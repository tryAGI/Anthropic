
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaErrorType
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
    public static class BetaErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaErrorType value)
        {
            return value switch
            {
                BetaErrorType.InvalidRequestError => "invalid_request_error",
                BetaErrorType.AuthenticationError => "authentication_error",
                BetaErrorType.PermissionError => "permission_error",
                BetaErrorType.NotFoundError => "not_found_error",
                BetaErrorType.RateLimitError => "rate_limit_error",
                BetaErrorType.TimeoutError => "timeout_error",
                BetaErrorType.OverloadedError => "overloaded_error",
                BetaErrorType.ApiError => "api_error",
                BetaErrorType.BillingError => "billing_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaErrorType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_request_error" => BetaErrorType.InvalidRequestError,
                "authentication_error" => BetaErrorType.AuthenticationError,
                "permission_error" => BetaErrorType.PermissionError,
                "not_found_error" => BetaErrorType.NotFoundError,
                "rate_limit_error" => BetaErrorType.RateLimitError,
                "timeout_error" => BetaErrorType.TimeoutError,
                "overloaded_error" => BetaErrorType.OverloadedError,
                "api_error" => BetaErrorType.ApiError,
                "billing_error" => BetaErrorType.BillingError,
                _ => null,
            };
        }
    }
}