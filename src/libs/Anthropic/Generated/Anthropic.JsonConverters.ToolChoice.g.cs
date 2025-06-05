#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ToolChoice>
    {
        /// <inheritdoc />
        public override global::Anthropic.ToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ToolChoiceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceAuto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceAuto> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ToolChoiceAuto)}");
                auto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ToolChoiceAny? any = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.Any)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceAny> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ToolChoiceAny)}");
                any = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ToolChoiceTool? tool = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ToolChoiceTool)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ToolChoiceNone? none = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ToolChoiceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.ToolChoice(
                discriminator?.Type,
                auto,
                any,
                tool,
                none
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceAuto), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceAuto?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolChoiceAuto).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeInfo);
            }
            else if (value.IsAny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceAny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceAny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolChoiceAny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolChoiceTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ToolChoiceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ToolChoiceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ToolChoiceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeInfo);
            }
        }
    }
}