#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsStreamSessionEventsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsStreamSessionEvents>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsStreamSessionEvents Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsUserMessageEvent? userMessage = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUserMessageEvent)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsUserInterruptEvent? userInterrupt = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserInterrupt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserInterruptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserInterruptEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUserInterruptEvent)}");
                userInterrupt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? userToolConfirmation = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserToolConfirmation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent)}");
                userToolConfirmation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? userCustomToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.UserCustomToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent)}");
                userCustomToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent? agentCustomToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentCustomToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent)}");
                agentCustomToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentMessageEvent? agentMessage = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentMessageEvent)}");
                agentMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentThinkingEvent? agentThinking = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentThinkingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentThinkingEvent)}");
                agentThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent? agentMcpToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMcpToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent)}");
                agentMcpToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent? agentMcpToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentMcpToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent)}");
                agentMcpToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentToolUseEvent? agentToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentToolUseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentToolUseEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentToolUseEvent)}");
                agentToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentToolResultEvent? agentToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentToolResultEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentToolResultEvent)}");
                agentToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent? agentThreadContextCompacted = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.AgentThreadContextCompacted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent)}");
                agentThreadContextCompacted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionErrorEvent? sessionError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionErrorEvent)}");
                sessionError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent? sessionStatusRescheduled = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRescheduled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent)}");
                sessionStatusRescheduled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent? sessionStatusRunning = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent)}");
                sessionStatusRunning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent? sessionStatusIdle = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent)}");
                sessionStatusIdle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent? sessionStatusTerminated = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionStatusTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent)}");
                sessionStatusTerminated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent? spanModelRequestStart = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent)}");
                spanModelRequestStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent? spanModelRequestEnd = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SpanModelRequestEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent)}");
                spanModelRequestEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsSessionDeletedEvent? sessionDeleted = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsStreamSessionEventsDiscriminatorType.SessionDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionDeletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent)}");
                sessionDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsStreamSessionEvents(
                discriminator?.Type,
                userMessage,

                userInterrupt,

                userToolConfirmation,

                userCustomToolResult,

                agentCustomToolUse,

                agentMessage,

                agentThinking,

                agentMcpToolUse,

                agentMcpToolResult,

                agentToolUse,

                agentToolResult,

                agentThreadContextCompacted,

                sessionError,

                sessionStatusRescheduled,

                sessionStatusRunning,

                sessionStatusIdle,

                sessionStatusTerminated,

                spanModelRequestStart,

                spanModelRequestEnd,

                sessionDeleted
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsStreamSessionEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserMessageEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUserMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage!, typeInfo);
            }
            else if (value.IsUserInterrupt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserInterruptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserInterruptEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUserInterruptEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInterrupt!, typeInfo);
            }
            else if (value.IsUserToolConfirmation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserToolConfirmation!, typeInfo);
            }
            else if (value.IsUserCustomToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserCustomToolResult!, typeInfo);
            }
            else if (value.IsAgentCustomToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentCustomToolUseEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentCustomToolUse!, typeInfo);
            }
            else if (value.IsAgentMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentMessageEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessage!, typeInfo);
            }
            else if (value.IsAgentThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentThinkingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentThinkingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentThinkingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThinking!, typeInfo);
            }
            else if (value.IsAgentMcpToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolUseEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMcpToolUse!, typeInfo);
            }
            else if (value.IsAgentMcpToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentMcpToolResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMcpToolResult!, typeInfo);
            }
            else if (value.IsAgentToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentToolUseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentToolUseEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentToolUseEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentToolUse!, typeInfo);
            }
            else if (value.IsAgentToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentToolResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentToolResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentToolResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentToolResult!, typeInfo);
            }
            else if (value.IsAgentThreadContextCompacted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentThreadContextCompactedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentThreadContextCompacted!, typeInfo);
            }
            else if (value.IsSessionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionError!, typeInfo);
            }
            else if (value.IsSessionStatusRescheduled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionStatusRescheduledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusRescheduled!, typeInfo);
            }
            else if (value.IsSessionStatusRunning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionStatusRunningEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusRunning!, typeInfo);
            }
            else if (value.IsSessionStatusIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusIdle!, typeInfo);
            }
            else if (value.IsSessionStatusTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionStatusTerminatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStatusTerminated!, typeInfo);
            }
            else if (value.IsSpanModelRequestStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpanModelRequestStart!, typeInfo);
            }
            else if (value.IsSpanModelRequestEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSpanModelRequestEndEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpanModelRequestEnd!, typeInfo);
            }
            else if (value.IsSessionDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionDeletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsSessionDeletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionDeleted!, typeInfo);
            }
        }
    }
}