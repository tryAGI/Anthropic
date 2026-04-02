#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaMessageStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaMessageStreamEvent>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaMessageStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMessageStreamEventDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaMessageStartEvent? messageStart = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageStreamEventDiscriminatorType.MessageStart)
            {
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMessageStartEvent>(ref reader, options);
            }
            global::Anthropic.BetaMessageDeltaEvent? messageDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageStreamEventDiscriminatorType.MessageDelta)
            {
                messageDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMessageDeltaEvent>(ref reader, options);
            }
            global::Anthropic.BetaMessageStopEvent? messageStop = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageStreamEventDiscriminatorType.MessageStop)
            {
                messageStop = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMessageStopEvent>(ref reader, options);
            }
            global::Anthropic.BetaContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageStreamEventDiscriminatorType.ContentBlockStart)
            {
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaContentBlockStartEvent>(ref reader, options);
            }
            global::Anthropic.BetaContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageStreamEventDiscriminatorType.ContentBlockDelta)
            {
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaContentBlockDeltaEvent>(ref reader, options);
            }
            global::Anthropic.BetaContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageStreamEventDiscriminatorType.ContentBlockStop)
            {
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaContentBlockStopEvent>(ref reader, options);
            }

            var __value = new global::Anthropic.BetaMessageStreamEvent(
                discriminator?.Type,
                messageStart,

                messageDelta,

                messageStop,

                contentBlockStart,

                contentBlockDelta,

                contentBlockStop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaMessageStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessageStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStart, typeof(global::Anthropic.BetaMessageStartEvent), options);
            }
            else if (value.IsMessageDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDelta, typeof(global::Anthropic.BetaMessageDeltaEvent), options);
            }
            else if (value.IsMessageStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageStop, typeof(global::Anthropic.BetaMessageStopEvent), options);
            }
            else if (value.IsContentBlockStart)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStart, typeof(global::Anthropic.BetaContentBlockStartEvent), options);
            }
            else if (value.IsContentBlockDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockDelta, typeof(global::Anthropic.BetaContentBlockDeltaEvent), options);
            }
            else if (value.IsContentBlockStop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockStop, typeof(global::Anthropic.BetaContentBlockStopEvent), options);
            }
        }
    }
}