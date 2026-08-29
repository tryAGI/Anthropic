
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Org-level role. A federation rule may only be created or retargeted to grant `org:admin` scope when this is `admin`. A rule granting `org:admin` whose target is later demoted to `developer` is rejected at token exchange. Rules granting `org:admin` are managed in the Console.
    /// </summary>
    public enum BetaServiceAccountOrganizationRole
    {
        /// <summary>
        /// admin` scope when this is `admin`. A rule granting `org:admin` whose target is later demoted to `developer` is rejected at token exchange. Rules granting `org:admin` are managed in the Console.
        /// </summary>
        Admin,
        /// <summary>
        /// admin` scope when this is `admin`. A rule granting `org:admin` whose target is later demoted to `developer` is rejected at token exchange. Rules granting `org:admin` are managed in the Console.
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaServiceAccountOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceAccountOrganizationRole value)
        {
            return value switch
            {
                BetaServiceAccountOrganizationRole.Admin => "admin",
                BetaServiceAccountOrganizationRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceAccountOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BetaServiceAccountOrganizationRole.Admin,
                "developer" => BetaServiceAccountOrganizationRole.Developer,
                _ => null,
            };
        }
    }
}