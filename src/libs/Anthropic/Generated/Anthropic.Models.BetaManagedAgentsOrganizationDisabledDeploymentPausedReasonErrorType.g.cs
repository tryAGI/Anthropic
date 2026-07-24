
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationDisabledError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType.OrganizationDisabledError => "organization_disabled_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "organization_disabled_error" => BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonErrorType.OrganizationDisabledError,
                _ => null,
            };
        }
    }
}