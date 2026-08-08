
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRunErrorDiscriminatorType
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
        SessionCreationRejectedError,
        /// <summary>
        /// 
        /// </summary>
        SessionRateLimitedError,
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
    public static class BetaManagedAgentsRunErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRunErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsRunErrorDiscriminatorType.AgentArchivedError => "agent_archived_error",
                BetaManagedAgentsRunErrorDiscriminatorType.EnvironmentArchivedError => "environment_archived_error",
                BetaManagedAgentsRunErrorDiscriminatorType.EnvironmentNotFoundError => "environment_not_found_error",
                BetaManagedAgentsRunErrorDiscriminatorType.FileNotFoundError => "file_not_found_error",
                BetaManagedAgentsRunErrorDiscriminatorType.McpEgressBlockedError => "mcp_egress_blocked_error",
                BetaManagedAgentsRunErrorDiscriminatorType.MemoryStoreArchivedError => "memory_store_archived_error",
                BetaManagedAgentsRunErrorDiscriminatorType.OrganizationDisabledError => "organization_disabled_error",
                BetaManagedAgentsRunErrorDiscriminatorType.SelfHostedResourcesUnsupportedError => "self_hosted_resources_unsupported_error",
                BetaManagedAgentsRunErrorDiscriminatorType.SessionCreationRejectedError => "session_creation_rejected_error",
                BetaManagedAgentsRunErrorDiscriminatorType.SessionRateLimitedError => "session_rate_limited_error",
                BetaManagedAgentsRunErrorDiscriminatorType.SessionResourceNotFoundError => "session_resource_not_found_error",
                BetaManagedAgentsRunErrorDiscriminatorType.SkillNotFoundError => "skill_not_found_error",
                BetaManagedAgentsRunErrorDiscriminatorType.UnknownError => "unknown_error",
                BetaManagedAgentsRunErrorDiscriminatorType.VaultArchivedError => "vault_archived_error",
                BetaManagedAgentsRunErrorDiscriminatorType.VaultNotFoundError => "vault_not_found_error",
                BetaManagedAgentsRunErrorDiscriminatorType.WorkspaceArchivedError => "workspace_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRunErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_archived_error" => BetaManagedAgentsRunErrorDiscriminatorType.AgentArchivedError,
                "environment_archived_error" => BetaManagedAgentsRunErrorDiscriminatorType.EnvironmentArchivedError,
                "environment_not_found_error" => BetaManagedAgentsRunErrorDiscriminatorType.EnvironmentNotFoundError,
                "file_not_found_error" => BetaManagedAgentsRunErrorDiscriminatorType.FileNotFoundError,
                "mcp_egress_blocked_error" => BetaManagedAgentsRunErrorDiscriminatorType.McpEgressBlockedError,
                "memory_store_archived_error" => BetaManagedAgentsRunErrorDiscriminatorType.MemoryStoreArchivedError,
                "organization_disabled_error" => BetaManagedAgentsRunErrorDiscriminatorType.OrganizationDisabledError,
                "self_hosted_resources_unsupported_error" => BetaManagedAgentsRunErrorDiscriminatorType.SelfHostedResourcesUnsupportedError,
                "session_creation_rejected_error" => BetaManagedAgentsRunErrorDiscriminatorType.SessionCreationRejectedError,
                "session_rate_limited_error" => BetaManagedAgentsRunErrorDiscriminatorType.SessionRateLimitedError,
                "session_resource_not_found_error" => BetaManagedAgentsRunErrorDiscriminatorType.SessionResourceNotFoundError,
                "skill_not_found_error" => BetaManagedAgentsRunErrorDiscriminatorType.SkillNotFoundError,
                "unknown_error" => BetaManagedAgentsRunErrorDiscriminatorType.UnknownError,
                "vault_archived_error" => BetaManagedAgentsRunErrorDiscriminatorType.VaultArchivedError,
                "vault_not_found_error" => BetaManagedAgentsRunErrorDiscriminatorType.VaultNotFoundError,
                "workspace_archived_error" => BetaManagedAgentsRunErrorDiscriminatorType.WorkspaceArchivedError,
                _ => null,
            };
        }
    }
}