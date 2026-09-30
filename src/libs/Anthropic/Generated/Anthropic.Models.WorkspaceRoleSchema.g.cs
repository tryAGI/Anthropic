
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkspaceRoleSchema
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
    public static class WorkspaceRoleSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRoleSchema value)
        {
            return value switch
            {
                WorkspaceRoleSchema.WorkspaceAdmin => "workspace_admin",
                WorkspaceRoleSchema.WorkspaceBilling => "workspace_billing",
                WorkspaceRoleSchema.WorkspaceDeveloper => "workspace_developer",
                WorkspaceRoleSchema.WorkspaceRestrictedDeveloper => "workspace_restricted_developer",
                WorkspaceRoleSchema.WorkspaceUser => "workspace_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRoleSchema? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => WorkspaceRoleSchema.WorkspaceAdmin,
                "workspace_billing" => WorkspaceRoleSchema.WorkspaceBilling,
                "workspace_developer" => WorkspaceRoleSchema.WorkspaceDeveloper,
                "workspace_restricted_developer" => WorkspaceRoleSchema.WorkspaceRestrictedDeveloper,
                "workspace_user" => WorkspaceRoleSchema.WorkspaceUser,
                _ => null,
            };
        }
    }
}