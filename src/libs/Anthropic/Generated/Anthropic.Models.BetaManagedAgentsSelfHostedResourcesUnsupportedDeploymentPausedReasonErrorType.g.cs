
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SelfHostedResourcesUnsupportedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType.SelfHostedResourcesUnsupportedError => "self_hosted_resources_unsupported_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "self_hosted_resources_unsupported_error" => BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonErrorType.SelfHostedResourcesUnsupportedError,
                _ => null,
            };
        }
    }
}