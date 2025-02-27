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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockDeltaEventDeltaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.TextContentBlockDelta? textDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.TextContentBlockDelta)}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.InputJsonContentBlockDelta? inputJsonDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.InputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.InputJsonContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.InputJsonContentBlockDelta)}");
                inputJsonDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CitationsDelta? citationsDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CitationsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CitationsDelta)}");
                citationsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ThinkingContentBlockDelta? thinkingDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ThinkingContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ThinkingContentBlockDelta)}");
                thinkingDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.SignatureContentBlockDelta? signatureDelta = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SignatureContentBlockDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SignatureContentBlockDelta)}");
                signatureDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Delta2(
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
            global::Anthropic.Delta2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeInfo);
            }
            else if (value.IsInputJsonDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.InputJsonContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.InputJsonContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.InputJsonContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputJsonDelta, typeInfo);
            }
            else if (value.IsCitationsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CitationsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CitationsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CitationsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CitationsDelta, typeInfo);
            }
            else if (value.IsThinkingDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ThinkingContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ThinkingContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ThinkingContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDelta, typeInfo);
            }
            else if (value.IsSignatureDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SignatureContentBlockDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SignatureContentBlockDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.SignatureContentBlockDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SignatureDelta, typeInfo);
            }
        }
    }
}