#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestDocumentBlockSourceDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaBase64PDFSource? base64 = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaBase64PDFSource>(ref reader, options);
            }
            global::Anthropic.BetaPlainTextSource? text = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaPlainTextSource>(ref reader, options);
            }
            global::Anthropic.BetaContentBlockSource? content = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType.Content)
            {
                content = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaContentBlockSource>(ref reader, options);
            }
            global::Anthropic.BetaURLPDFSource? url = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaURLPDFSource>(ref reader, options);
            }
            global::Anthropic.BetaFileDocumentSource? file = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestDocumentBlockSourceDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaFileDocumentSource>(ref reader, options);
            }

            var __value = new global::Anthropic.Source(
                discriminator?.Type,
                base64,

                text,

                content,

                url,

                file
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source value,
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
            else if (value.IsContent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Content, typeof(global::Anthropic.BetaContentBlockSource), options);
            }
            else if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::Anthropic.BetaURLPDFSource), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::Anthropic.BetaFileDocumentSource), options);
            }
        }
    }
}