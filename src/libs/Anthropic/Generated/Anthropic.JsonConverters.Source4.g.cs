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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestDocumentBlockSourceDiscriminator>(ref readerCopy, options);

            global::Anthropic.Base64PDFSource? base64 = default;
            if (discriminator?.Type == global::Anthropic.RequestDocumentBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.Base64PDFSource>(ref reader, options);
            }
            global::Anthropic.PlainTextSource? text = default;
            if (discriminator?.Type == global::Anthropic.RequestDocumentBlockSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.PlainTextSource>(ref reader, options);
            }
            global::Anthropic.ContentBlockSource? content = default;
            if (discriminator?.Type == global::Anthropic.RequestDocumentBlockSourceDiscriminatorType.Content)
            {
                content = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockSource>(ref reader, options);
            }
            global::Anthropic.URLPDFSource? url = default;
            if (discriminator?.Type == global::Anthropic.RequestDocumentBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.URLPDFSource>(ref reader, options);
            }

            var __value = new global::Anthropic.Source4(
                discriminator?.Type,
                base64,

                text,

                content,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::Anthropic.Base64PDFSource), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.PlainTextSource), options);
            }
            else if (value.IsContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Content, typeof(global::Anthropic.ContentBlockSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::Anthropic.URLPDFSource), options);
            }
        }
    }
}