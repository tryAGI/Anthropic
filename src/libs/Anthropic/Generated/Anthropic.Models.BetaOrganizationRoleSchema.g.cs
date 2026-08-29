
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaOrganizationRoleSchema
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        ClaudeCodeUser,
        /// <summary>
        ///
        /// </summary>
        Developer,
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
    public static class BetaOrganizationRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOrganizationRoleSchema value)
        {
            return value switch
            {
                BetaOrganizationRoleSchema.Admin => "admin",
                BetaOrganizationRoleSchema.Billing => "billing",
                BetaOrganizationRoleSchema.ClaudeCodeUser => "claude_code_user",
                BetaOrganizationRoleSchema.Developer => "developer",
                BetaOrganizationRoleSchema.Managed => "managed",
                BetaOrganizationRoleSchema.MembershipAdmin => "membership_admin",
                BetaOrganizationRoleSchema.Owner => "owner",
                BetaOrganizationRoleSchema.PrimaryOwner => "primary_owner",
                BetaOrganizationRoleSchema.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOrganizationRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BetaOrganizationRoleSchema.Admin,
                "billing" => BetaOrganizationRoleSchema.Billing,
                "claude_code_user" => BetaOrganizationRoleSchema.ClaudeCodeUser,
                "developer" => BetaOrganizationRoleSchema.Developer,
                "managed" => BetaOrganizationRoleSchema.Managed,
                "membership_admin" => BetaOrganizationRoleSchema.MembershipAdmin,
                "owner" => BetaOrganizationRoleSchema.Owner,
                "primary_owner" => BetaOrganizationRoleSchema.PrimaryOwner,
                "user" => BetaOrganizationRoleSchema.User,
                _ => null,
            };
        }
    }
}