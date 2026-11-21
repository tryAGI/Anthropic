
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaErrorDiscriminatorType
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
    public static class BetaErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaErrorDiscriminatorType.ApiError => "api_error",
                BetaErrorDiscriminatorType.AuthenticationError => "authentication_error",
                BetaErrorDiscriminatorType.BillingError => "billing_error",
                BetaErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                BetaErrorDiscriminatorType.NotFoundError => "not_found_error",
                BetaErrorDiscriminatorType.OverloadedError => "overloaded_error",
                BetaErrorDiscriminatorType.PermissionError => "permission_error",
                BetaErrorDiscriminatorType.RateLimitError => "rate_limit_error",
                BetaErrorDiscriminatorType.TimeoutError => "timeout_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => BetaErrorDiscriminatorType.ApiError,
                "authentication_error" => BetaErrorDiscriminatorType.AuthenticationError,
                "billing_error" => BetaErrorDiscriminatorType.BillingError,
                "invalid_request_error" => BetaErrorDiscriminatorType.InvalidRequestError,
                "not_found_error" => BetaErrorDiscriminatorType.NotFoundError,
                "overloaded_error" => BetaErrorDiscriminatorType.OverloadedError,
                "permission_error" => BetaErrorDiscriminatorType.PermissionError,
                "rate_limit_error" => BetaErrorDiscriminatorType.RateLimitError,
                "timeout_error" => BetaErrorDiscriminatorType.TimeoutError,
                _ => null,
            };
        }
    }
}