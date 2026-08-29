
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWorkspaceRoleSchema
    {
        /// <summary>
        ///
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        ///
        /// </summary>
        WorkspaceBilling,
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
    public static class BetaWorkspaceRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceRoleSchema value)
        {
            return value switch
            {
                BetaWorkspaceRoleSchema.WorkspaceAdmin => "workspace_admin",
                BetaWorkspaceRoleSchema.WorkspaceBilling => "workspace_billing",
                BetaWorkspaceRoleSchema.WorkspaceDeveloper => "workspace_developer",
                BetaWorkspaceRoleSchema.WorkspaceRestrictedDeveloper => "workspace_restricted_developer",
                BetaWorkspaceRoleSchema.WorkspaceUser => "workspace_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => BetaWorkspaceRoleSchema.WorkspaceAdmin,
                "workspace_billing" => BetaWorkspaceRoleSchema.WorkspaceBilling,
                "workspace_developer" => BetaWorkspaceRoleSchema.WorkspaceDeveloper,
                "workspace_restricted_developer" => BetaWorkspaceRoleSchema.WorkspaceRestrictedDeveloper,
                "workspace_user" => BetaWorkspaceRoleSchema.WorkspaceUser,
                _ => null,
            };
        }
    }
}