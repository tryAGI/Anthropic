
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSessionErrorEventErrorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        BillingError,
        /// <summary>
        /// 
        /// </summary>
        McpAuthenticationFailedError,
        /// <summary>
        /// 
        /// </summary>
        McpConnectionFailedError,
        /// <summary>
        /// 
        /// </summary>
        ModelOverloadedError,
        /// <summary>
        /// 
        /// </summary>
        ModelRateLimitedError,
        /// <summary>
        /// 
        /// </summary>
        ModelRequestFailedError,
        /// <summary>
        /// 
        /// </summary>
        UnknownError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionErrorEventErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionErrorEventErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.BillingError => "billing_error",
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.McpAuthenticationFailedError => "mcp_authentication_failed_error",
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.McpConnectionFailedError => "mcp_connection_failed_error",
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelOverloadedError => "model_overloaded_error",
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelRateLimitedError => "model_rate_limited_error",
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelRequestFailedError => "model_request_failed_error",
                BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.UnknownError => "unknown_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "billing_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.BillingError,
                "mcp_authentication_failed_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.McpAuthenticationFailedError,
                "mcp_connection_failed_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.McpConnectionFailedError,
                "model_overloaded_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelOverloadedError,
                "model_rate_limited_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelRateLimitedError,
                "model_request_failed_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelRequestFailedError,
                "unknown_error" => BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.UnknownError,
                _ => null,
            };
        }
    }
}