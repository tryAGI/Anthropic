#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Source3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source3>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseDocumentBlockSourceDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaBase64PDFSource? base64 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaBase64PDFSource>(ref reader, options);
            }
            global::Anthropic.BetaPlainTextSource? text = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseDocumentBlockSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaPlainTextSource>(ref reader, options);
            }

            var __value = new global::Anthropic.Source3(
                discriminator?.Type,
                base64,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::Anthropic.BetaBase64PDFSource), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.BetaPlainTextSource), options);
            }
        }
    }
}