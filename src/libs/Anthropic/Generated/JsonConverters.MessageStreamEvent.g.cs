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

            global::Anthropic.MessageStartEvent? start = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageStartEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.MessageDeltaEvent? delta = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageDeltaEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.MessageStopEvent? stop = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageStopEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockStartEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockDeltaEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockStopEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.PingEvent? ping = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.PingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.PingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.PingEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ErrorEvent? error = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ErrorEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.MessageStreamEvent(
                discriminator?.Type,
                start,
                delta,
                stop,
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

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MessageStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeInfo);
            }
            else if (value.IsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MessageDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Delta, typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MessageStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop, typeInfo);
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