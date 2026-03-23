
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
    public static class BetaErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaErrorType value)
        {
            return value switch
            {
                BetaErrorType.ApiError => "api_error",
                BetaErrorType.AuthenticationError => "authentication_error",
                BetaErrorType.BillingError => "billing_error",
                BetaErrorType.InvalidRequestError => "invalid_request_error",
                BetaErrorType.NotFoundError => "not_found_error",
                BetaErrorType.OverloadedError => "overloaded_error",
                BetaErrorType.PermissionError => "permission_error",
                BetaErrorType.RateLimitError => "rate_limit_error",
                BetaErrorType.TimeoutError => "timeout_error",
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
                "api_error" => BetaErrorType.ApiError,
                "authentication_error" => BetaErrorType.AuthenticationError,
                "billing_error" => BetaErrorType.BillingError,
                "invalid_request_error" => BetaErrorType.InvalidRequestError,
                "not_found_error" => BetaErrorType.NotFoundError,
                "overloaded_error" => BetaErrorType.OverloadedError,
                "permission_error" => BetaErrorType.PermissionError,
                "rate_limit_error" => BetaErrorType.RateLimitError,
                "timeout_error" => BetaErrorType.TimeoutError,
                _ => null,
            };
        }
    }
}