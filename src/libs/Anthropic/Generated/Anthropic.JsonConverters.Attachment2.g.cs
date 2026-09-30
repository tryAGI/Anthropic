#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Attachment2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Attachment2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Attachment2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ExternalKeyAttachmentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ExternalKeyAttachmentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ExternalKeyAttachmentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.AttachedAttachment? attached = default;
            if (discriminator?.Type == global::Anthropic.ExternalKeyAttachmentDiscriminatorType.Attached)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AttachedAttachment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AttachedAttachment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.AttachedAttachment)}");
                attached = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.UnattachedAttachment? unattached = default;
            if (discriminator?.Type == global::Anthropic.ExternalKeyAttachmentDiscriminatorType.Unattached)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UnattachedAttachment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UnattachedAttachment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UnattachedAttachment)}");
                unattached = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Attachment2(
                discriminator?.Type,
                attached,

                unattached
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Attachment2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAttached)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AttachedAttachment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AttachedAttachment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AttachedAttachment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAttached(), typeInfo);
            }
            else if (value.IsUnattached)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UnattachedAttachment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UnattachedAttachment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UnattachedAttachment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnattached(), typeInfo);
            }
        }
    }
}