#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsEventDeltaEventDeltaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsEventDeltaEventDelta>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsEventDeltaEventDelta Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta? contentDelta = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsEventDeltaEventDeltaDiscriminatorType.ContentDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta)}");
                contentDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsEventDeltaEventDelta(
                discriminator?.Type,
                contentDelta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsEventDeltaEventDelta value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsContentDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsEventDeltaEventContentDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentDelta!, typeInfo);
            }
        }
    }
}