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

                vaultCredentialRefreshFailed
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
        }
    }
}