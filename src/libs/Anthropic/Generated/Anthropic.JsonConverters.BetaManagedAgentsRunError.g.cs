#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsRunErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsRunError>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsRunError Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRunErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRunErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsRunErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError? environmentArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.EnvironmentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError)}");
                environmentArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentArchivedRunError? agentArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.AgentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentArchivedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentArchivedRunError)}");
                agentArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError? environmentNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.EnvironmentNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError)}");
                environmentNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsVaultNotFoundRunError? vaultNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.VaultNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultNotFoundRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError)}");
                vaultNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsVaultArchivedRunError? vaultArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.VaultArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultArchivedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsVaultArchivedRunError)}");
                vaultArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsFileNotFoundRunError? fileNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.FileNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsFileNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsFileNotFoundRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsFileNotFoundRunError)}");
                fileNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError? memoryStoreArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.MemoryStoreArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError)}");
                memoryStoreArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSkillNotFoundRunError? skillNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.SkillNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSkillNotFoundRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError)}");
                skillNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError? sessionResourceNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.SessionResourceNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError)}");
                sessionResourceNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError? workspaceArchivedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.WorkspaceArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError)}");
                workspaceArchivedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError? organizationDisabledError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.OrganizationDisabledError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError)}");
                organizationDisabledError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError? sessionRateLimitedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.SessionRateLimitedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError)}");
                sessionRateLimitedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError? sessionCreationRejectedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.SessionCreationRejectedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError)}");
                sessionCreationRejectedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsUnknownRunError? unknownError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.UnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUnknownRunError)}");
                unknownError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError? selfHostedResourcesUnsupportedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.SelfHostedResourcesUnsupportedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError)}");
                selfHostedResourcesUnsupportedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError? mcpEgressBlockedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsRunErrorDiscriminatorType.McpEgressBlockedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError)}");
                mcpEgressBlockedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsRunError(
                discriminator?.Type,
                environmentArchivedError,

                agentArchivedError,

                environmentNotFoundError,

                vaultNotFoundError,

                vaultArchivedError,

                fileNotFoundError,

                memoryStoreArchivedError,

                skillNotFoundError,

                sessionResourceNotFoundError,

                workspaceArchivedError,

                organizationDisabledError,

                sessionRateLimitedError,

                sessionCreationRejectedError,

                unknownError,

                selfHostedResourcesUnsupportedError,

                mcpEgressBlockedError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsRunError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnvironmentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsEnvironmentArchivedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentArchivedError!, typeInfo);
            }
            else if (value.IsAgentArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentArchivedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentArchivedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentArchivedError!, typeInfo);
            }
            else if (value.IsEnvironmentNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsEnvironmentNotFoundRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentNotFoundError!, typeInfo);
            }
            else if (value.IsVaultNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultNotFoundRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsVaultNotFoundRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultNotFoundError!, typeInfo);
            }
            else if (value.IsVaultArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsVaultArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsVaultArchivedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsVaultArchivedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultArchivedError!, typeInfo);
            }
            else if (value.IsFileNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsFileNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsFileNotFoundRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsFileNotFoundRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileNotFoundError!, typeInfo);
            }
            else if (value.IsMemoryStoreArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMemoryStoreArchivedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryStoreArchivedError!, typeInfo);
            }
            else if (value.IsSkillNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSkillNotFoundRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSkillNotFoundRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkillNotFoundError!, typeInfo);
            }
            else if (value.IsSessionResourceNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionResourceNotFoundRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionResourceNotFoundError!, typeInfo);
            }
            else if (value.IsWorkspaceArchivedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkspaceArchivedError!, typeInfo);
            }
            else if (value.IsOrganizationDisabledError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsOrganizationDisabledRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrganizationDisabledError!, typeInfo);
            }
            else if (value.IsSessionRateLimitedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionRateLimitedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionRateLimitedError!, typeInfo);
            }
            else if (value.IsSessionCreationRejectedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionCreationRejectedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreationRejectedError!, typeInfo);
            }
            else if (value.IsUnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUnknownRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UnknownError!, typeInfo);
            }
            else if (value.IsSelfHostedResourcesUnsupportedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSelfHostedResourcesUnsupportedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SelfHostedResourcesUnsupportedError!, typeInfo);
            }
            else if (value.IsMcpEgressBlockedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMcpEgressBlockedRunError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpEgressBlockedError!, typeInfo);
            }
        }
    }
}