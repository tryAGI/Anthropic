#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant150JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CacheControlVariant150>
    {
        /// <inheritdoc />
        public override global::Anthropic.CacheControlVariant150 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CreateMessageParamsCacheControlVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.CacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::Anthropic.CreateMessageParamsCacheControlVariant1DiscriminatorType.Ephemeral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheControlEphemeral), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheControlEphemeral> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheControlEphemeral)}");
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.CacheControlVariant150(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CacheControlVariant150 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEphemeral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheControlEphemeral), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheControlEphemeral?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheControlEphemeral).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ephemeral!, typeInfo);
            }
        }
    }
}