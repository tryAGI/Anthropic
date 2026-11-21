#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class StopDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.StopDetails>
    {
        /// <inheritdoc />
        public override global::Anthropic.StopDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.StopDetailsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.StopDetailsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.StopDetailsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.RefusalStopDetails? refusal = default;
            if (discriminator?.Type == global::Anthropic.StopDetailsDiscriminatorType.Refusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RefusalStopDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RefusalStopDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RefusalStopDetails)}");
                refusal = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.StopDetails(
                discriminator?.Type,
                refusal
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.StopDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsRefusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RefusalStopDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RefusalStopDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RefusalStopDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRefusal(), typeInfo);
            }
        }
    }
}