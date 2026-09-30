
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Org-level role. Defaults to `developer`.
    /// </summary>
    public enum ServiceAccountCreateParamsOrganizationRole
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
    public static class ServiceAccountCreateParamsOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceAccountCreateParamsOrganizationRole value)
        {
            return value switch
            {
                ServiceAccountCreateParamsOrganizationRole.Admin => "admin",
                ServiceAccountCreateParamsOrganizationRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceAccountCreateParamsOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ServiceAccountCreateParamsOrganizationRole.Admin,
                "developer" => ServiceAccountCreateParamsOrganizationRole.Developer,
                _ => null,
            };
        }
    }
}