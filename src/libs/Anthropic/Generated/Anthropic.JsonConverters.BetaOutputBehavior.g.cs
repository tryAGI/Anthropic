#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaOutputBehaviorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaOutputBehavior>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaOutputBehavior Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOutputBehaviorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOutputBehaviorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaOutputBehaviorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaOutputBehaviorCreateNew? createNew = default;
            if (discriminator?.Type == global::Anthropic.BetaOutputBehaviorDiscriminatorType.CreateNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOutputBehaviorCreateNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOutputBehaviorCreateNew> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaOutputBehaviorCreateNew)}");
                createNew = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaOutputBehaviorUpdateExisting? updateExisting = default;
            if (discriminator?.Type == global::Anthropic.BetaOutputBehaviorDiscriminatorType.UpdateExisting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOutputBehaviorUpdateExisting), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOutputBehaviorUpdateExisting> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaOutputBehaviorUpdateExisting)}");
                updateExisting = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaOutputBehavior(
                discriminator?.Type,
                createNew,

                updateExisting
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaOutputBehavior value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOutputBehaviorCreateNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOutputBehaviorCreateNew?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaOutputBehaviorCreateNew).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateNew!, typeInfo);
            }
            else if (value.IsUpdateExisting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOutputBehaviorUpdateExisting), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOutputBehaviorUpdateExisting?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaOutputBehaviorUpdateExisting).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateExisting!, typeInfo);
            }
        }
    }
}