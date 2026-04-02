#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ContentContentBlockSourceContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ContentContentBlockSourceContentItem>
    {
        /// <inheritdoc />
        public override global::Anthropic.ContentContentBlockSourceContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.RequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestTextBlock>(ref reader, options);
            }
            global::Anthropic.RequestImageBlock? image = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestImageBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.ContentContentBlockSourceContentItem(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ContentContentBlockSourceContentItem value,
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
        }
    }
}