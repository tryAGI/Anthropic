#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaWebhookEventDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaWebhookEventData>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaWebhookEventData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEventDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEventDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookEventDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaWebhookSessionCreatedEventData? sessionCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionCreatedEventData)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionPendingEventData? sessionPending = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionPendingEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionPendingEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionPendingEventData)}");
                sessionPending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionRunningEventData? sessionRunning = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionRunningEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionRunningEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionRunningEventData)}");
                sessionRunning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionIdledEventData? sessionIdled = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionIdled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionIdledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionIdledEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionIdledEventData)}");
                sessionIdled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionRequiresActionEventData? sessionRequiresAction = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionRequiresActionEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionRequiresActionEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionRequiresActionEventData)}");
                sessionRequiresAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionArchivedEventData? sessionArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionArchivedEventData)}");
                sessionArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionDeletedEventData? sessionDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionDeletedEventData)}");
                sessionDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionStatusRescheduledEventData? sessionStatusRescheduled = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionStatusRescheduled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusRescheduledEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData)}");
                sessionStatusRescheduled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionStatusRunStartedEventData? sessionStatusRunStarted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionStatusRunStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusRunStartedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData)}");
                sessionStatusRunStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionStatusIdledEventData? sessionStatusIdled = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionStatusIdled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusIdledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusIdledEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionStatusIdledEventData)}");
                sessionStatusIdled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionStatusTerminatedEventData? sessionStatusTerminated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionStatusTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusTerminatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData)}");
                sessionStatusTerminated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionThreadCreatedEventData? sessionThreadCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionThreadCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionThreadCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionThreadCreatedEventData)}");
                sessionThreadCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionThreadIdledEventData? sessionThreadIdled = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionThreadIdled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionThreadIdledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionThreadIdledEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionThreadIdledEventData)}");
                sessionThreadIdled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionThreadTerminatedEventData? sessionThreadTerminated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionThreadTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionThreadTerminatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData)}");
                sessionThreadTerminated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData? sessionOutcomeEvaluationEnded = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionOutcomeEvaluationEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData)}");
                sessionOutcomeEvaluationEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultCreatedEventData? vaultCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultCreatedEventData)}");
                vaultCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultArchivedEventData? vaultArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultArchivedEventData)}");
                vaultArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultDeletedEventData? vaultDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultDeletedEventData)}");
                vaultDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultCredentialCreatedEventData? vaultCredentialCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultCredentialCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData)}");
                vaultCredentialCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultCredentialArchivedEventData? vaultCredentialArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultCredentialArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData)}");
                vaultCredentialArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultCredentialDeletedEventData? vaultCredentialDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultCredentialDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData)}");
                vaultCredentialDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData? vaultCredentialRefreshFailed = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.VaultCredentialRefreshFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData)}");
                vaultCredentialRefreshFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookSessionUpdatedEventData? sessionUpdated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionUpdatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookSessionUpdatedEventData)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookAgentCreatedEventData? agentCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.AgentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookAgentCreatedEventData)}");
                agentCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookAgentArchivedEventData? agentArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.AgentArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookAgentArchivedEventData)}");
                agentArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookAgentDeletedEventData? agentDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.AgentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookAgentDeletedEventData)}");
                agentDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentPausedEventData? deploymentPaused = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentPaused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentPausedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentPausedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentPausedEventData)}");
                deploymentPaused = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentRunFailedEventData? deploymentRunFailed = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentRunFailedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentRunFailedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentRunFailedEventData)}");
                deploymentRunFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentCreatedEventData? deploymentCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentCreatedEventData)}");
                deploymentCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentUpdatedEventData? deploymentUpdated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentUpdatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentUpdatedEventData)}");
                deploymentUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentUnpausedEventData? deploymentUnpaused = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentUnpaused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentUnpausedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentUnpausedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentUnpausedEventData)}");
                deploymentUnpaused = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookAgentUpdatedEventData? agentUpdated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.AgentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentUpdatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookAgentUpdatedEventData)}");
                agentUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentArchivedEventData? deploymentArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentArchivedEventData)}");
                deploymentArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentRunStartedEventData? deploymentRunStarted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentRunStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentRunStartedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentRunStartedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentRunStartedEventData)}");
                deploymentRunStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentDeletedEventData? deploymentDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentDeletedEventData)}");
                deploymentDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookDeploymentRunSucceededEventData? deploymentRunSucceeded = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.DeploymentRunSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentRunSucceededEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData)}");
                deploymentRunSucceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookEnvironmentCreatedEventData? environmentCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.EnvironmentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookEnvironmentCreatedEventData)}");
                environmentCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookEnvironmentUpdatedEventData? environmentUpdated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.EnvironmentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentUpdatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData)}");
                environmentUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookEnvironmentArchivedEventData? environmentArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.EnvironmentArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookEnvironmentArchivedEventData)}");
                environmentArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookEnvironmentDeletedEventData? environmentDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.EnvironmentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookEnvironmentDeletedEventData)}");
                environmentDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookMemoryStoreCreatedEventData? memoryStoreCreated = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.MemoryStoreCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookMemoryStoreCreatedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData)}");
                memoryStoreCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookMemoryStoreArchivedEventData? memoryStoreArchived = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.MemoryStoreArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookMemoryStoreArchivedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData)}");
                memoryStoreArchived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWebhookMemoryStoreDeletedEventData? memoryStoreDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaWebhookEventDataDiscriminatorType.MemoryStoreDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookMemoryStoreDeletedEventData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData)}");
                memoryStoreDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaWebhookEventData(
                discriminator?.Type,
                sessionCreated,

                sessionPending,

                sessionRunning,

                sessionIdled,

                sessionRequiresAction,

                sessionArchived,

                sessionDeleted,

                sessionStatusRescheduled,

                sessionStatusRunStarted,

                sessionStatusIdled,

                sessionStatusTerminated,

                sessionThreadCreated,

                sessionThreadIdled,

                sessionThreadTerminated,

                sessionOutcomeEvaluationEnded,

                vaultCreated,

                vaultArchived,

                vaultDeleted,

                vaultCredentialCreated,

                vaultCredentialArchived,

                vaultCredentialDeleted,

                vaultCredentialRefreshFailed,

                sessionUpdated,

                agentCreated,

                agentArchived,

                agentDeleted,

                deploymentPaused,

                deploymentRunFailed,

                deploymentCreated,

                deploymentUpdated,

                deploymentUnpaused,

                agentUpdated,

                deploymentArchived,

                deploymentRunStarted,

                deploymentDeleted,

                deploymentRunSucceeded,

                environmentCreated,

                environmentUpdated,

                environmentArchived,

                environmentDeleted,

                memoryStoreCreated,

                memoryStoreArchived,

                memoryStoreDeleted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaWebhookEventData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsSessionPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionPendingEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionPendingEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionPendingEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionPending!, typeInfo);
            }
            else if (value.IsSessionRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionRunningEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionRunningEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionRunningEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionRunning!, typeInfo);
            }
            else if (value.IsSessionIdled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionIdledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionIdledEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionIdledEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionIdled!, typeInfo);
            }
            else if (value.IsSessionRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionRequiresActionEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionRequiresActionEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionRequiresActionEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionRequiresAction!, typeInfo);
            }
            else if (value.IsSessionArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionArchived!, typeInfo);
            }
            else if (value.IsSessionDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionDeleted!, typeInfo);
            }
            else if (value.IsSessionStatusRescheduled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusRescheduledEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionStatusRescheduledEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusRescheduled!, typeInfo);
            }
            else if (value.IsSessionStatusRunStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusRunStartedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionStatusRunStartedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusRunStarted!, typeInfo);
            }
            else if (value.IsSessionStatusIdled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusIdledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusIdledEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionStatusIdledEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusIdled!, typeInfo);
            }
            else if (value.IsSessionStatusTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionStatusTerminatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionStatusTerminatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusTerminated!, typeInfo);
            }
            else if (value.IsSessionThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionThreadCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionThreadCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionThreadCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionThreadCreated!, typeInfo);
            }
            else if (value.IsSessionThreadIdled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionThreadIdledEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionThreadIdledEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionThreadIdledEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionThreadIdled!, typeInfo);
            }
            else if (value.IsSessionThreadTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionThreadTerminatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionThreadTerminatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionThreadTerminated!, typeInfo);
            }
            else if (value.IsSessionOutcomeEvaluationEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionOutcomeEvaluationEndedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionOutcomeEvaluationEnded!, typeInfo);
            }
            else if (value.IsVaultCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultCreated!, typeInfo);
            }
            else if (value.IsVaultArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultArchived!, typeInfo);
            }
            else if (value.IsVaultDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultDeleted!, typeInfo);
            }
            else if (value.IsVaultCredentialCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultCredentialCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultCredentialCreated!, typeInfo);
            }
            else if (value.IsVaultCredentialArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultCredentialArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultCredentialArchived!, typeInfo);
            }
            else if (value.IsVaultCredentialDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultCredentialDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultCredentialDeleted!, typeInfo);
            }
            else if (value.IsVaultCredentialRefreshFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookVaultCredentialRefreshFailedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VaultCredentialRefreshFailed!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookSessionUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookSessionUpdatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookSessionUpdatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsAgentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookAgentCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentCreated!, typeInfo);
            }
            else if (value.IsAgentArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookAgentArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentArchived!, typeInfo);
            }
            else if (value.IsAgentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookAgentDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentDeleted!, typeInfo);
            }
            else if (value.IsDeploymentPaused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentPausedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentPausedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentPausedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentPaused!, typeInfo);
            }
            else if (value.IsDeploymentRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentRunFailedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentRunFailedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentRunFailedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentRunFailed!, typeInfo);
            }
            else if (value.IsDeploymentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentCreated!, typeInfo);
            }
            else if (value.IsDeploymentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentUpdatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentUpdatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentUpdated!, typeInfo);
            }
            else if (value.IsDeploymentUnpaused)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentUnpausedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentUnpausedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentUnpausedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentUnpaused!, typeInfo);
            }
            else if (value.IsAgentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookAgentUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookAgentUpdatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookAgentUpdatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentUpdated!, typeInfo);
            }
            else if (value.IsDeploymentArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentArchived!, typeInfo);
            }
            else if (value.IsDeploymentRunStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentRunStartedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentRunStartedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentRunStartedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentRunStarted!, typeInfo);
            }
            else if (value.IsDeploymentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentDeleted!, typeInfo);
            }
            else if (value.IsDeploymentRunSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookDeploymentRunSucceededEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookDeploymentRunSucceededEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeploymentRunSucceeded!, typeInfo);
            }
            else if (value.IsEnvironmentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookEnvironmentCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentCreated!, typeInfo);
            }
            else if (value.IsEnvironmentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentUpdatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookEnvironmentUpdatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentUpdated!, typeInfo);
            }
            else if (value.IsEnvironmentArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookEnvironmentArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentArchived!, typeInfo);
            }
            else if (value.IsEnvironmentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookEnvironmentDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookEnvironmentDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookEnvironmentDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentDeleted!, typeInfo);
            }
            else if (value.IsMemoryStoreCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookMemoryStoreCreatedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookMemoryStoreCreatedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryStoreCreated!, typeInfo);
            }
            else if (value.IsMemoryStoreArchived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookMemoryStoreArchivedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookMemoryStoreArchivedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryStoreArchived!, typeInfo);
            }
            else if (value.IsMemoryStoreDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebhookMemoryStoreDeletedEventData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebhookMemoryStoreDeletedEventData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryStoreDeleted!, typeInfo);
            }
        }
    }
}