
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SelfHostedResourcesUnsupportedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorType.SelfHostedResourcesUnsupportedError => "self_hosted_resources_unsupported_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "self_hosted_resources_unsupported_error" => BetaManagedAgentsSelfHostedResourcesUnsupportedRunErrorType.SelfHostedResourcesUnsupportedError,
                _ => null,
            };
        }
    }
}