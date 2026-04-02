#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::Anthropic.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaRequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestTextBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestImageBlock? image = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestImageBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestSearchResultBlock? searchResult = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.SearchResult)
            {
                searchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestSearchResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestDocumentBlock? document = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestDocumentBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestToolReferenceBlock? toolReference = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolResultBlockContentVariant2ItemDiscriminatorType.ToolReference)
            {
                toolReference = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestToolReferenceBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.ContentVariant2Item(
                discriminator?.Type,
                text,

                image,

                searchResult,

                document,

                toolReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ContentVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.BetaRequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Anthropic.BetaRequestImageBlock), options);
            }
            else if (value.IsSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResult, typeof(global::Anthropic.BetaRequestSearchResultBlock), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::Anthropic.BetaRequestDocumentBlock), options);
            }
            else if (value.IsToolReference)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReference, typeof(global::Anthropic.BetaRequestToolReferenceBlock), options);
            }
        }
    }
}