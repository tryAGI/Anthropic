
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Org-level role. Defaults to `developer`.
    /// </summary>
    public enum BetaServiceAccountCreateParamsOrganizationRole
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
    public static class BetaServiceAccountCreateParamsOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceAccountCreateParamsOrganizationRole value)
        {
            return value switch
            {
                BetaServiceAccountCreateParamsOrganizationRole.Admin => "admin",
                BetaServiceAccountCreateParamsOrganizationRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceAccountCreateParamsOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BetaServiceAccountCreateParamsOrganizationRole.Admin,
                "developer" => BetaServiceAccountCreateParamsOrganizationRole.Developer,
                _ => null,
            };
        }
    }
}