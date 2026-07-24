
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsOrganizationDisabledRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationDisabledError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsOrganizationDisabledRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsOrganizationDisabledRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsOrganizationDisabledRunErrorType.OrganizationDisabledError => "organization_disabled_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsOrganizationDisabledRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "organization_disabled_error" => BetaManagedAgentsOrganizationDisabledRunErrorType.OrganizationDisabledError,
                _ => null,
            };
        }
    }
}