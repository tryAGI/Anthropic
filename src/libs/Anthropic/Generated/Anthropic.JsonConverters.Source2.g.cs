#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Source2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestImageBlockSourceDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaBase64ImageSource? base64 = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaBase64ImageSource>(ref reader, options);
            }
            global::Anthropic.BetaURLImageSource? url = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaURLImageSource>(ref reader, options);
            }
            global::Anthropic.BetaFileImageSource? file = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestImageBlockSourceDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaFileImageSource>(ref reader, options);
            }

            var __value = new global::Anthropic.Source2(
                discriminator?.Type,
                base64,

                url,

                file
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::Anthropic.BetaBase64ImageSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::Anthropic.BetaURLImageSource), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::Anthropic.BetaFileImageSource), options);
            }
        }
    }
}