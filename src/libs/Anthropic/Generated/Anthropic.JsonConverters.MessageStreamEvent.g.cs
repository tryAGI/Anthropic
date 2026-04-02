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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.MessageStreamEventDiscriminator>(ref readerCopy, options);

            global::Anthropic.MessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStart)
            {
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.MessageStartEvent>(ref reader, options);
            }
            global::Anthropic.MessageDeltaEvent? messageDelta = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageDelta)
            {
                messageDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.MessageDeltaEvent>(ref reader, options);
            }
            global::Anthropic.MessageStopEvent? messageStop = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.MessageStop)
            {
                messageStop = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.MessageStopEvent>(ref reader, options);
            }
            global::Anthropic.ContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.ContentBlockStart)
            {
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockStartEvent>(ref reader, options);
            }
            global::Anthropic.ContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.ContentBlockDelta)
            {
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockDeltaEvent>(ref reader, options);
            }
            global::Anthropic.ContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.ContentBlockStop)
            {
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockStopEvent>(ref reader, options);
            }
            global::Anthropic.Ping? ping = default;
            if (discriminator?.Type == global::Anthropic.MessageStreamEventDiscriminatorType.Ping)
            {
                ping = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.Ping>(ref reader, options);
            }

            var __value = new global::Anthropic.MessageStreamEvent(
                discriminator?.Type,
                messageStart,

                messageDelta,

                messageStop,

                contentBlockStart,

                contentBlockDelta,

                contentBlockStop,

                ping
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.MessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessageStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeof(global::Anthropic.MessageStartEvent), options);
            }
            else if (value.IsMessageDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDelta, typeof(global::Anthropic.MessageDeltaEvent), options);
            }
            else if (value.IsMessageStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStop, typeof(global::Anthropic.MessageStopEvent), options);
            }
            else if (value.IsContentBlockStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart, typeof(global::Anthropic.ContentBlockStartEvent), options);
            }
            else if (value.IsContentBlockDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta, typeof(global::Anthropic.ContentBlockDeltaEvent), options);
            }
            else if (value.IsContentBlockStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop, typeof(global::Anthropic.ContentBlockStopEvent), options);
            }
            else if (value.IsPing)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeof(global::Anthropic.Ping), options);
            }
        }
    }
}