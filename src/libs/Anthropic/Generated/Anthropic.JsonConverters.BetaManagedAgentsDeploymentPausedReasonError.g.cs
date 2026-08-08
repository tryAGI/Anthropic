#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsDeploymentPausedReasonErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError? environmentArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.EnvironmentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError)}");
                environmentArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError? agentArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.AgentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError)}");
                agentArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError? environmentNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.EnvironmentNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError)}");
                environmentNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError? vaultNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.VaultNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError)}");
                vaultNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError? fileNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.FileNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError)}");
                fileNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError? sessionResourceNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SessionResourceNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError)}");
                sessionResourceNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError? workspaceArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.WorkspaceArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError)}");
                workspaceArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError? organizationDisabledError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.OrganizationDisabledError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError)}");
                organizationDisabledError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError? memoryStoreArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.MemoryStoreArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError)}");
                memoryStoreArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError? skillNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SkillNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError)}");
                skillNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError? vaultArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.VaultArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError)}");
                vaultArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError? unknownError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.UnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError)}");
                unknownError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError? selfHostedResourcesUnsupportedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.SelfHostedResourcesUnsupportedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError)}");
                selfHostedResourcesUnsupportedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError? mcpEgressBlockedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentPausedReasonErrorDiscriminatorType.McpEgressBlockedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError)}");
                mcpEgressBlockedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError(
                discriminator?.Type,
                environmentArchivedError,

                agentArchivedError,

                environmentNotFoundError,

                vaultNotFoundError,

                fileNotFoundError,

                sessionResourceNotFoundError,

                workspaceArchivedError,

                organizationDisabledError,

                memoryStoreArchivedError,

                skillNotFoundError,

                vaultArchivedError,

                unknownError,

                selfHostedResourcesUnsupportedError,

                mcpEgressBlockedError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnvironmentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentArchivedError!, typeInfo);
            }
            else if (value.IsAgentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentArchivedError!, typeInfo);
            }
            else if (value.IsEnvironmentNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentNotFoundError!, typeInfo);
            }
            else if (value.IsVaultNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultNotFoundError!, typeInfo);
            }
            else if (value.IsFileNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsFileNotFoundDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileNotFoundError!, typeInfo);
            }
            else if (value.IsSessionResourceNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionResourceNotFoundError!, typeInfo);
            }
            else if (value.IsWorkspaceArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkspaceArchivedError!, typeInfo);
            }
            else if (value.IsOrganizationDisabledError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationDisabledError!, typeInfo);
            }
            else if (value.IsMemoryStoreArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryStoreArchivedError!, typeInfo);
            }
            else if (value.IsSkillNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkillNotFoundError!, typeInfo);
            }
            else if (value.IsVaultArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsVaultArchivedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultArchivedError!, typeInfo);
            }
            else if (value.IsUnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUnknownDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnknownError!, typeInfo);
            }
            else if (value.IsSelfHostedResourcesUnsupportedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelfHostedResourcesUnsupportedError!, typeInfo);
            }
            else if (value.IsMcpEgressBlockedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpEgressBlockedError!, typeInfo);
            }
        }
    }
}