#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ToolChangesVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ToolChangesVariant1Item2>
    {
        /// <inheritdoc />
        public override global::Anthropic.ToolChangesVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaResponseToolAdditionBlock? toolAddition = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolAddition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolAdditionBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolAdditionBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseToolAdditionBlock)}");
                toolAddition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseToolRemovalBlock? toolRemoval = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType.ToolRemoval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolRemovalBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolRemovalBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseToolRemovalBlock)}");
                toolRemoval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ToolChangesVariant1Item2(
                discriminator?.Type,
                toolAddition,

                toolRemoval
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ToolChangesVariant1Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolAddition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolAdditionBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolAdditionBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseToolAdditionBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolAddition!, typeInfo);
            }
            else if (value.IsToolRemoval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolRemovalBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolRemovalBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseToolRemovalBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolRemoval!, typeInfo);
            }
        }
    }
}