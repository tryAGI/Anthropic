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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaTextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTextContentBlockDelta)}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaInputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaInputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaInputJsonContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaInputJsonContentBlockDelta)}");
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaCitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCitationsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCitationsDelta)}");
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaThinkingContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaThinkingContentBlockDelta)}");
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaSignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaSignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaSignatureContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaSignatureContentBlockDelta)}");
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Delta(
                discriminator?.Type,
                textDelta,
                inputJsonDelta,
                citationsDelta,
                thinkingDelta,
                signatureDelta
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Delta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeInfo);
            }
            else if (value.IsInputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaInputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaInputJsonContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaInputJsonContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeInfo);
            }
            else if (value.IsCitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCitationsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCitationsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeInfo);
            }
            else if (value.IsThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaThinkingContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaThinkingContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeInfo);
            }
            else if (value.IsSignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaSignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaSignatureContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaSignatureContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeInfo);
            }
        }
    }
}