#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CitationsItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CitationsItem4>
    {
        /// <inheritdoc />
        public override global::Anthropic.CitationsItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseTextBlockCitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseTextBlockCitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseTextBlockCitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ResponseCharLocationCitation? charLocation = default;
            if (discriminator?.Type == global::Anthropic.ResponseTextBlockCitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseCharLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseCharLocationCitation)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponsePageLocationCitation? pageLocation = default;
            if (discriminator?.Type == global::Anthropic.ResponseTextBlockCitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponsePageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponsePageLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponsePageLocationCitation)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseContentBlockLocationCitation? contentBlockLocation = default;
            if (discriminator?.Type == global::Anthropic.ResponseTextBlockCitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseContentBlockLocationCitation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseContentBlockLocationCitation)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.CitationsItem4(
                discriminator?.Type,
                charLocation,
                pageLocation,
                contentBlockLocation
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CitationsItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseCharLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseCharLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseCharLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation, typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponsePageLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponsePageLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponsePageLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation, typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseContentBlockLocationCitation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseContentBlockLocationCitation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseContentBlockLocationCitation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation, typeInfo);
            }
        }
    }
}