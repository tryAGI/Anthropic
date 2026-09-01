
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaDreamingErrorDiscriminatorType
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
        ConflictError,
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
    public static class BetaDreamingErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDreamingErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaDreamingErrorDiscriminatorType.ApiError => "api_error",
                BetaDreamingErrorDiscriminatorType.AuthenticationError => "authentication_error",
                BetaDreamingErrorDiscriminatorType.BillingError => "billing_error",
                BetaDreamingErrorDiscriminatorType.ConflictError => "conflict_error",
                BetaDreamingErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                BetaDreamingErrorDiscriminatorType.NotFoundError => "not_found_error",
                BetaDreamingErrorDiscriminatorType.OverloadedError => "overloaded_error",
                BetaDreamingErrorDiscriminatorType.PermissionError => "permission_error",
                BetaDreamingErrorDiscriminatorType.RateLimitError => "rate_limit_error",
                BetaDreamingErrorDiscriminatorType.TimeoutError => "timeout_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDreamingErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => BetaDreamingErrorDiscriminatorType.ApiError,
                "authentication_error" => BetaDreamingErrorDiscriminatorType.AuthenticationError,
                "billing_error" => BetaDreamingErrorDiscriminatorType.BillingError,
                "conflict_error" => BetaDreamingErrorDiscriminatorType.ConflictError,
                "invalid_request_error" => BetaDreamingErrorDiscriminatorType.InvalidRequestError,
                "not_found_error" => BetaDreamingErrorDiscriminatorType.NotFoundError,
                "overloaded_error" => BetaDreamingErrorDiscriminatorType.OverloadedError,
                "permission_error" => BetaDreamingErrorDiscriminatorType.PermissionError,
                "rate_limit_error" => BetaDreamingErrorDiscriminatorType.RateLimitError,
                "timeout_error" => BetaDreamingErrorDiscriminatorType.TimeoutError,
                _ => null,
            };
        }
    }
}