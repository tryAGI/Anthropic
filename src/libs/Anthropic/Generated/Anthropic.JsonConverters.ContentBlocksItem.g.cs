#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ContentBlocksItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ContentBlocksItem>
    {
        /// <inheritdoc />
        public override global::Anthropic.ContentBlocksItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SystemInputMessageContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SystemInputMessageContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SystemInputMessageContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.RequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.SystemInputMessageContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ContentBlocksItem(
                discriminator?.Type,
                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ContentBlocksItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
        }
    }
}