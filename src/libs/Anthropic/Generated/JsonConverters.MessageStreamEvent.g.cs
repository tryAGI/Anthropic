#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class MessageStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.MessageStreamEvent>
    {
        /// <inheritdoc />
        public override global::Anthropic.MessageStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.MessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageStartEvent)}");
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.MessageDeltaEvent? messageDelta = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageDeltaEvent)}");
                messageDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.MessageStopEvent? messageStop = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageStopEvent)}");
                messageStop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.ContentBlockStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockStartEvent)}");
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.ContentBlockDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockDeltaEvent)}");
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.ContentBlockStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockStopEvent)}");
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.PingEvent? ping = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.Ping)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.PingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.PingEvent)}");
                ping = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ErrorEvent? error = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.MessageStreamEvent(
                discriminator?.Type,
                messageStart,
                messageDelta,
                messageStop,
                contentBlockStart,
                contentBlockDelta,
                contentBlockStop,
                ping,
                error
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.MessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MessageStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeInfo);
            }
            else if (value.IsMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MessageDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDelta, typeInfo);
            }
            else if (value.IsMessageStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MessageStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStop, typeInfo);
            }
            else if (value.IsContentBlockStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ContentBlockStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart, typeInfo);
            }
            else if (value.IsContentBlockDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ContentBlockDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta, typeInfo);
            }
            else if (value.IsContentBlockStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ContentBlockStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop, typeInfo);
            }
            else if (value.IsPing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.PingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.PingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}