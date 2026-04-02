#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ContentVariant2Item2>
    {
        /// <inheritdoc />
        public override global::Anthropic.ContentVariant2Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.RequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestTextBlock>(ref reader, options);
            }
            global::Anthropic.RequestImageBlock? image = default;
            if (discriminator?.Type == global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestImageBlock>(ref reader, options);
            }
            global::Anthropic.RequestSearchResultBlock? searchResult = default;
            if (discriminator?.Type == global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType.SearchResult)
            {
                searchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestSearchResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestDocumentBlock? document = default;
            if (discriminator?.Type == global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestDocumentBlock>(ref reader, options);
            }
            global::Anthropic.RequestToolReferenceBlock? toolReference = default;
            if (discriminator?.Type == global::Anthropic.RequestToolResultBlockContentVariant2ItemDiscriminatorType.ToolReference)
            {
                toolReference = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestToolReferenceBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.ContentVariant2Item2(
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
            global::Anthropic.ContentVariant2Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.RequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Anthropic.RequestImageBlock), options);
            }
            else if (value.IsSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResult, typeof(global::Anthropic.RequestSearchResultBlock), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::Anthropic.RequestDocumentBlock), options);
            }
            else if (value.IsToolReference)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReference, typeof(global::Anthropic.RequestToolReferenceBlock), options);
            }
        }
    }
}