
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentArchivedError,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentArchivedError,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentNotFoundError,
        /// <summary>
        /// 
        /// </summary>
        FileNotFoundError,
        /// <summary>
        /// 
        /// </summary>
        McpEgressBlockedError,
        /// <summary>
        /// 
        /// </summary>
        MemoryStoreArchivedError,
        /// <summary>
        /// 
        /// </summary>
        OrganizationDisabledError,
        /// <summary>
        /// 
        /// </summary>
        SelfHostedResourcesUnsupportedError,
        /// <summary>
        /// 
        /// </summary>
        SessionResourceNotFoundError,
        /// <summary>
        /// 
        /// </summary>
        SkillNotFoundError,
        /// <summary>
        /// 
        /// </summary>
        UnknownError,
        /// <summary>
        /// 
        /// </summary>
        VaultArchivedError,
        /// <summary>
        /// 
        /// </summary>
        VaultNotFoundError,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.AgentArchivedError => "agent_archived_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.EnvironmentArchivedError => "environment_archived_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.EnvironmentNotFoundError => "environment_not_found_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.FileNotFoundError => "file_not_found_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.McpEgressBlockedError => "mcp_egress_blocked_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.MemoryStoreArchivedError => "memory_store_archived_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.OrganizationDisabledError => "organization_disabled_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SelfHostedResourcesUnsupportedError => "self_hosted_resources_unsupported_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SessionResourceNotFoundError => "session_resource_not_found_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SkillNotFoundError => "skill_not_found_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.UnknownError => "unknown_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.VaultArchivedError => "vault_archived_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.VaultNotFoundError => "vault_not_found_error",
                BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.WorkspaceArchivedError => "workspace_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_archived_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.AgentArchivedError,
                "environment_archived_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.EnvironmentArchivedError,
                "environment_not_found_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.EnvironmentNotFoundError,
                "file_not_found_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.FileNotFoundError,
                "mcp_egress_blocked_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.McpEgressBlockedError,
                "memory_store_archived_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.MemoryStoreArchivedError,
                "organization_disabled_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.OrganizationDisabledError,
                "self_hosted_resources_unsupported_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SelfHostedResourcesUnsupportedError,
                "session_resource_not_found_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SessionResourceNotFoundError,
                "skill_not_found_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SkillNotFoundError,
                "unknown_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.UnknownError,
                "vault_archived_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.VaultArchivedError,
                "vault_not_found_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.VaultNotFoundError,
                "workspace_archived_error" => BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.WorkspaceArchivedError,
                _ => null,
            };
        }
    }
}