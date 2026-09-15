#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaInputTransformationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaInputTransformation>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaInputTransformation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaInputTransformationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaInputTransformationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaInputTransformationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaThinkingDroppedInputTransformation? thinkingDropped = default;
            if (discriminator?.Type == global::Anthropic.BetaInputTransformationDiscriminatorType.ThinkingDropped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaThinkingDroppedInputTransformation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaThinkingDroppedInputTransformation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaThinkingDroppedInputTransformation)}");
                thinkingDropped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaThinkingMismatchAllowedInputTransformation? thinkingMismatchAllowed = default;
            if (discriminator?.Type == global::Anthropic.BetaInputTransformationDiscriminatorType.ThinkingMismatchAllowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaThinkingMismatchAllowedInputTransformation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation)}");
                thinkingMismatchAllowed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaInputTransformation(
                discriminator?.Type,
                thinkingDropped,

                thinkingMismatchAllowed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaInputTransformation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThinkingDropped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaThinkingDroppedInputTransformation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaThinkingDroppedInputTransformation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaThinkingDroppedInputTransformation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingDropped!, typeInfo);
            }
            else if (value.IsThinkingMismatchAllowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaThinkingMismatchAllowedInputTransformation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaThinkingMismatchAllowedInputTransformation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingMismatchAllowed!, typeInfo);
            }
        }
    }
}