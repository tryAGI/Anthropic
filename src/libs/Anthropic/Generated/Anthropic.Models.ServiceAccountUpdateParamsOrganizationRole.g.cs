
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ServiceAccountUpdateParamsOrganizationRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceAccountUpdateParamsOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceAccountUpdateParamsOrganizationRole value)
        {
            return value switch
            {
                ServiceAccountUpdateParamsOrganizationRole.Admin => "admin",
                ServiceAccountUpdateParamsOrganizationRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceAccountUpdateParamsOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ServiceAccountUpdateParamsOrganizationRole.Admin,
                "developer" => ServiceAccountUpdateParamsOrganizationRole.Developer,
                _ => null,
            };
        }
    }
}