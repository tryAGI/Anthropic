
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum OrganizationRoleSchema
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
    public static class OrganizationRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleSchema value)
        {
            return value switch
            {
                OrganizationRoleSchema.Admin => "admin",
                OrganizationRoleSchema.Billing => "billing",
                OrganizationRoleSchema.ClaudeCodeUser => "claude_code_user",
                OrganizationRoleSchema.Developer => "developer",
                OrganizationRoleSchema.Managed => "managed",
                OrganizationRoleSchema.MembershipAdmin => "membership_admin",
                OrganizationRoleSchema.Owner => "owner",
                OrganizationRoleSchema.PrimaryOwner => "primary_owner",
                OrganizationRoleSchema.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrganizationRoleSchema.Admin,
                "billing" => OrganizationRoleSchema.Billing,
                "claude_code_user" => OrganizationRoleSchema.ClaudeCodeUser,
                "developer" => OrganizationRoleSchema.Developer,
                "managed" => OrganizationRoleSchema.Managed,
                "membership_admin" => OrganizationRoleSchema.MembershipAdmin,
                "owner" => OrganizationRoleSchema.Owner,
                "primary_owner" => OrganizationRoleSchema.PrimaryOwner,
                "user" => OrganizationRoleSchema.User,
                _ => null,
            };
        }
    }
}