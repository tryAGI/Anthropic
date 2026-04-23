
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsErrorDiscriminatorType
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
        MemoryPathConflictError,
        /// <summary>
        /// 
        /// </summary>
        MemoryPreconditionFailedError,
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
    public static class BetaManagedAgentsErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsErrorDiscriminatorType.ApiError => "api_error",
                BetaManagedAgentsErrorDiscriminatorType.AuthenticationError => "authentication_error",
                BetaManagedAgentsErrorDiscriminatorType.BillingError => "billing_error",
                BetaManagedAgentsErrorDiscriminatorType.ConflictError => "conflict_error",
                BetaManagedAgentsErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                BetaManagedAgentsErrorDiscriminatorType.MemoryPathConflictError => "memory_path_conflict_error",
                BetaManagedAgentsErrorDiscriminatorType.MemoryPreconditionFailedError => "memory_precondition_failed_error",
                BetaManagedAgentsErrorDiscriminatorType.NotFoundError => "not_found_error",
                BetaManagedAgentsErrorDiscriminatorType.OverloadedError => "overloaded_error",
                BetaManagedAgentsErrorDiscriminatorType.PermissionError => "permission_error",
                BetaManagedAgentsErrorDiscriminatorType.RateLimitError => "rate_limit_error",
                BetaManagedAgentsErrorDiscriminatorType.TimeoutError => "timeout_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => BetaManagedAgentsErrorDiscriminatorType.ApiError,
                "authentication_error" => BetaManagedAgentsErrorDiscriminatorType.AuthenticationError,
                "billing_error" => BetaManagedAgentsErrorDiscriminatorType.BillingError,
                "conflict_error" => BetaManagedAgentsErrorDiscriminatorType.ConflictError,
                "invalid_request_error" => BetaManagedAgentsErrorDiscriminatorType.InvalidRequestError,
                "memory_path_conflict_error" => BetaManagedAgentsErrorDiscriminatorType.MemoryPathConflictError,
                "memory_precondition_failed_error" => BetaManagedAgentsErrorDiscriminatorType.MemoryPreconditionFailedError,
                "not_found_error" => BetaManagedAgentsErrorDiscriminatorType.NotFoundError,
                "overloaded_error" => BetaManagedAgentsErrorDiscriminatorType.OverloadedError,
                "permission_error" => BetaManagedAgentsErrorDiscriminatorType.PermissionError,
                "rate_limit_error" => BetaManagedAgentsErrorDiscriminatorType.RateLimitError,
                "timeout_error" => BetaManagedAgentsErrorDiscriminatorType.TimeoutError,
                _ => null,
            };
        }
    }
}