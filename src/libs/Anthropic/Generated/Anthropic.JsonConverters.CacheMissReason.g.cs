#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CacheMissReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CacheMissReason>
    {
        /// <inheritdoc />
        public override global::Anthropic.CacheMissReason Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissReasonDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissReasonDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissReasonDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.CacheMissModelChanged? modelChanged = default;
            if (discriminator?.Type == global::Anthropic.CacheMissReasonDiscriminatorType.ModelChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissModelChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissModelChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissModelChanged)}");
                modelChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CacheMissSystemChanged? systemChanged = default;
            if (discriminator?.Type == global::Anthropic.CacheMissReasonDiscriminatorType.SystemChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissSystemChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissSystemChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissSystemChanged)}");
                systemChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CacheMissToolsChanged? toolsChanged = default;
            if (discriminator?.Type == global::Anthropic.CacheMissReasonDiscriminatorType.ToolsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissToolsChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissToolsChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissToolsChanged)}");
                toolsChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CacheMissMessagesChanged? messagesChanged = default;
            if (discriminator?.Type == global::Anthropic.CacheMissReasonDiscriminatorType.MessagesChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissMessagesChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissMessagesChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissMessagesChanged)}");
                messagesChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CacheMissPreviousMessageNotFound? previousMessageNotFound = default;
            if (discriminator?.Type == global::Anthropic.CacheMissReasonDiscriminatorType.PreviousMessageNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissPreviousMessageNotFound), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissPreviousMessageNotFound> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissPreviousMessageNotFound)}");
                previousMessageNotFound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CacheMissUnavailable? unavailable = default;
            if (discriminator?.Type == global::Anthropic.CacheMissReasonDiscriminatorType.Unavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissUnavailable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissUnavailable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CacheMissUnavailable)}");
                unavailable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.CacheMissReason(
                discriminator?.Type,
                modelChanged,

                systemChanged,

                toolsChanged,

                messagesChanged,

                previousMessageNotFound,

                unavailable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CacheMissReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissModelChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissModelChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheMissModelChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelChanged(), typeInfo);
            }
            else if (value.IsSystemChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissSystemChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissSystemChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheMissSystemChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSystemChanged(), typeInfo);
            }
            else if (value.IsToolsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissToolsChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissToolsChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheMissToolsChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickToolsChanged(), typeInfo);
            }
            else if (value.IsMessagesChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissMessagesChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissMessagesChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheMissMessagesChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessagesChanged(), typeInfo);
            }
            else if (value.IsPreviousMessageNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissPreviousMessageNotFound), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissPreviousMessageNotFound?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheMissPreviousMessageNotFound).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPreviousMessageNotFound(), typeInfo);
            }
            else if (value.IsUnavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CacheMissUnavailable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CacheMissUnavailable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CacheMissUnavailable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnavailable(), typeInfo);
            }
        }
    }
}