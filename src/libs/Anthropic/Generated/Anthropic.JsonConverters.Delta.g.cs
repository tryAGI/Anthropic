#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class DeltaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Delta>
    {
        /// <inheritdoc />
        public override global::Anthropic.Delta Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaTextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaTextContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.BetaInputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaInputJsonContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.BetaCitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaCitationsDelta>(ref reader, options);
            }
            global::Anthropic.BetaThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaThinkingContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.BetaSignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaSignatureContentBlockDelta>(ref reader, options);
            }
            global::Anthropic.BetaCompactionContentBlockDelta? compactionDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.CompactionDelta)
            {
                compactionDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaCompactionContentBlockDelta>(ref reader, options);
            }

            var __value = new global::Anthropic.Delta(
                discriminator?.Type,
                textDelta,

                inputJsonDelta,

                citationsDelta,

                thinkingDelta,

                signatureDelta,

                compactionDelta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Delta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeof(global::Anthropic.BetaTextContentBlockDelta), options);
            }
            else if (value.IsInputJsonDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeof(global::Anthropic.BetaInputJsonContentBlockDelta), options);
            }
            else if (value.IsCitationsDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeof(global::Anthropic.BetaCitationsDelta), options);
            }
            else if (value.IsThinkingDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeof(global::Anthropic.BetaThinkingContentBlockDelta), options);
            }
            else if (value.IsSignatureDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeof(global::Anthropic.BetaSignatureContentBlockDelta), options);
            }
            else if (value.IsCompactionDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompactionDelta, typeof(global::Anthropic.BetaCompactionContentBlockDelta), options);
            }
        }
    }
}