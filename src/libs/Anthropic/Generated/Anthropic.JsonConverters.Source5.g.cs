#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Source5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source5>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestImageBlockSourceDiscriminator>(ref readerCopy, options);

            global::Anthropic.Base64ImageSource? base64 = default;
            if (discriminator?.Type == global::Anthropic.RequestImageBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.Base64ImageSource>(ref reader, options);
            }
            global::Anthropic.URLImageSource? url = default;
            if (discriminator?.Type == global::Anthropic.RequestImageBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.URLImageSource>(ref reader, options);
            }

            var __value = new global::Anthropic.Source5(
                discriminator?.Type,
                base64,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::Anthropic.Base64ImageSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::Anthropic.URLImageSource), options);
            }
        }
    }
}