#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsSystemContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsSystemContentBlock>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsSystemContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSystemContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsSystemContentBlock(
                discriminator?.Type,
                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsSystemContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}