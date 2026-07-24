#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CacheMissReasonVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CacheMissReasonVariant1>
    {
        /// <inheritdoc />
        public override global::Anthropic.CacheMissReasonVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaCacheMissModelChanged? modelChanged = default;
            if (discriminator?.Type == global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.ModelChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissModelChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissModelChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheMissModelChanged)}");
                modelChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaCacheMissSystemChanged? systemChanged = default;
            if (discriminator?.Type == global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.SystemChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissSystemChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissSystemChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheMissSystemChanged)}");
                systemChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaCacheMissToolsChanged? toolsChanged = default;
            if (discriminator?.Type == global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.ToolsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissToolsChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissToolsChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheMissToolsChanged)}");
                toolsChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaCacheMissMessagesChanged? messagesChanged = default;
            if (discriminator?.Type == global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.MessagesChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissMessagesChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissMessagesChanged> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheMissMessagesChanged)}");
                messagesChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaCacheMissPreviousMessageNotFound? previousMessageNotFound = default;
            if (discriminator?.Type == global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.PreviousMessageNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissPreviousMessageNotFound), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissPreviousMessageNotFound> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheMissPreviousMessageNotFound)}");
                previousMessageNotFound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaCacheMissUnavailable? unavailable = default;
            if (discriminator?.Type == global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType.Unavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissUnavailable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissUnavailable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheMissUnavailable)}");
                unavailable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.CacheMissReasonVariant1(
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
            global::Anthropic.CacheMissReasonVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissModelChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissModelChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheMissModelChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelChanged!, typeInfo);
            }
            else if (value.IsSystemChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissSystemChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissSystemChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheMissSystemChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemChanged!, typeInfo);
            }
            else if (value.IsToolsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissToolsChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissToolsChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheMissToolsChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolsChanged!, typeInfo);
            }
            else if (value.IsMessagesChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissMessagesChanged), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissMessagesChanged?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheMissMessagesChanged).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesChanged!, typeInfo);
            }
            else if (value.IsPreviousMessageNotFound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissPreviousMessageNotFound), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissPreviousMessageNotFound?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheMissPreviousMessageNotFound).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreviousMessageNotFound!, typeInfo);
            }
            else if (value.IsUnavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheMissUnavailable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheMissUnavailable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheMissUnavailable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unavailable!, typeInfo);
            }
        }
    }
}