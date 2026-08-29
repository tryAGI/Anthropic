
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaNoBillingWorkspaceRoleSchema
    {
        /// <summary>
        ///
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        ///
        /// </summary>
        WorkspaceDeveloper,
        /// <summary>
        ///
        /// </summary>
        WorkspaceRestrictedDeveloper,
        /// <summary>
        ///
        /// </summary>
        WorkspaceUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaNoBillingWorkspaceRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaNoBillingWorkspaceRoleSchema value)
        {
            return value switch
            {
                BetaNoBillingWorkspaceRoleSchema.WorkspaceAdmin => "workspace_admin",
                BetaNoBillingWorkspaceRoleSchema.WorkspaceDeveloper => "workspace_developer",
                BetaNoBillingWorkspaceRoleSchema.WorkspaceRestrictedDeveloper => "workspace_restricted_developer",
                BetaNoBillingWorkspaceRoleSchema.WorkspaceUser => "workspace_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaNoBillingWorkspaceRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => BetaNoBillingWorkspaceRoleSchema.WorkspaceAdmin,
                "workspace_developer" => BetaNoBillingWorkspaceRoleSchema.WorkspaceDeveloper,
                "workspace_restricted_developer" => BetaNoBillingWorkspaceRoleSchema.WorkspaceRestrictedDeveloper,
                "workspace_user" => BetaNoBillingWorkspaceRoleSchema.WorkspaceUser,
                _ => null,
            };
        }
    }
}