#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BrowserClickTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BrowserClickTarget>
    {
        /// <inheritdoc />
        public override global::Anthropic.BrowserClickTarget Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserClickTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserClickTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserClickTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BrowserCoordinateTarget? coordinate = default;
            if (discriminator?.Type == global::Anthropic.BrowserClickTargetDiscriminatorType.Coordinate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserCoordinateTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserCoordinateTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserCoordinateTarget)}");
                coordinate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BrowserRefTarget? @ref = default;
            if (discriminator?.Type == global::Anthropic.BrowserClickTargetDiscriminatorType.Ref)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserRefTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserRefTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BrowserRefTarget)}");
                @ref = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BrowserClickTarget(
                discriminator?.Type,
                coordinate,

                @ref
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BrowserClickTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCoordinate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserCoordinateTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserCoordinateTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserCoordinateTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCoordinate(), typeInfo);
            }
            else if (value.IsRef)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserRefTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserRefTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserRefTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRef(), typeInfo);
            }
        }
    }
}