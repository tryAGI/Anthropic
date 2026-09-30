
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum NoBillingWorkspaceRoleSchema
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
    public static class NoBillingWorkspaceRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NoBillingWorkspaceRoleSchema value)
        {
            return value switch
            {
                NoBillingWorkspaceRoleSchema.WorkspaceAdmin => "workspace_admin",
                NoBillingWorkspaceRoleSchema.WorkspaceDeveloper => "workspace_developer",
                NoBillingWorkspaceRoleSchema.WorkspaceRestrictedDeveloper => "workspace_restricted_developer",
                NoBillingWorkspaceRoleSchema.WorkspaceUser => "workspace_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NoBillingWorkspaceRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => NoBillingWorkspaceRoleSchema.WorkspaceAdmin,
                "workspace_developer" => NoBillingWorkspaceRoleSchema.WorkspaceDeveloper,
                "workspace_restricted_developer" => NoBillingWorkspaceRoleSchema.WorkspaceRestrictedDeveloper,
                "workspace_user" => NoBillingWorkspaceRoleSchema.WorkspaceUser,
                _ => null,
            };
        }
    }
}