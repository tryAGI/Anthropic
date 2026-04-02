#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Delta2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Delta2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Delta2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator>(ref readerCopy, options);

            global::Anthropic.TextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.TextContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.InputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.InputJsonContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.CitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.CitationsDelta>(ref reader, options);
            }
            global::Anthropic.ThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ThinkingContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.SignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.SignatureContentBlockDelta>(ref reader, options);
            }

            var __value = new global::Anthropic.Delta2(
                discriminator?.Type,
                textDelta,

                inputJsonDelta,

                citationsDelta,

                thinkingDelta,

                signatureDelta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Delta2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeof(global::Anthropic.TextContentBlockDelta), options);
            }
            else if (value.IsInputJsonDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeof(global::Anthropic.InputJsonContentBlockDelta), options);
            }
            else if (value.IsCitationsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeof(global::Anthropic.CitationsDelta), options);
            }
            else if (value.IsThinkingDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeof(global::Anthropic.ThinkingContentBlockDelta), options);
            }
            else if (value.IsSignatureDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeof(global::Anthropic.SignatureContentBlockDelta), options);
            }
        }
    }
}