
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaServiceAccountUpdateParamsOrganizationRole
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
    public static class BetaServiceAccountUpdateParamsOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceAccountUpdateParamsOrganizationRole value)
        {
            return value switch
            {
                BetaServiceAccountUpdateParamsOrganizationRole.Admin => "admin",
                BetaServiceAccountUpdateParamsOrganizationRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceAccountUpdateParamsOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BetaServiceAccountUpdateParamsOrganizationRole.Admin,
                "developer" => BetaServiceAccountUpdateParamsOrganizationRole.Developer,
                _ => null,
            };
        }
    }
}