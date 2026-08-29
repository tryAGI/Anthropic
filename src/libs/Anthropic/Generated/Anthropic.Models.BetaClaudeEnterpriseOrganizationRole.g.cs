
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Organization role values for Claude Enterprise organizations.
    /// </summary>
    public enum BetaClaudeEnterpriseOrganizationRole
    {
        /// <summary>
        ///
        /// </summary>
        Managed,
        /// <summary>
        ///
        /// </summary>
        MembershipAdmin,
        /// <summary>
        ///
        /// </summary>
        Owner,
        /// <summary>
        ///
        /// </summary>
        PrimaryOwner,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeEnterpriseOrganizationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeEnterpriseOrganizationRole value)
        {
            return value switch
            {
                BetaClaudeEnterpriseOrganizationRole.Managed => "managed",
                BetaClaudeEnterpriseOrganizationRole.MembershipAdmin => "membership_admin",
                BetaClaudeEnterpriseOrganizationRole.Owner => "owner",
                BetaClaudeEnterpriseOrganizationRole.PrimaryOwner => "primary_owner",
                BetaClaudeEnterpriseOrganizationRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeEnterpriseOrganizationRole? ToEnum(string value)
        {
            return value switch
            {
                "managed" => BetaClaudeEnterpriseOrganizationRole.Managed,
                "membership_admin" => BetaClaudeEnterpriseOrganizationRole.MembershipAdmin,
                "owner" => BetaClaudeEnterpriseOrganizationRole.Owner,
                "primary_owner" => BetaClaudeEnterpriseOrganizationRole.PrimaryOwner,
                "user" => BetaClaudeEnterpriseOrganizationRole.User,
                _ => null,
            };
        }
    }
}