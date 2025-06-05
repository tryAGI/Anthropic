#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Source4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source4>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestImageBlockSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestImageBlockSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestImageBlockSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.Base64ImageSource? base64 = default;
            if (discriminator?.Type == global::Anthropic.RequestImageBlockSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.Base64ImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.Base64ImageSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.Base64ImageSource)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.URLImageSource? url = default;
            if (discriminator?.Type == global::Anthropic.RequestImageBlockSourceDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.URLImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.URLImageSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.URLImageSource)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Source4(
                discriminator?.Type,
                base64,
                url
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.Base64ImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.Base64ImageSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.Base64ImageSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.URLImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.URLImageSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.URLImageSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
        }
    }
}