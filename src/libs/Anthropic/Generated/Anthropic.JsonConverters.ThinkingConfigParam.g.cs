#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ThinkingConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ThinkingConfigParam>
    {
        /// <inheritdoc />
        public override global::Anthropic.ThinkingConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ThinkingConfigParamDiscriminator>(ref readerCopy, options);

            global::Anthropic.ThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::Anthropic.ThinkingConfigParamDiscriminatorType.Enabled)
            {
                enabled = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ThinkingConfigEnabled>(ref reader, options);
            }
            global::Anthropic.ThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::Anthropic.ThinkingConfigParamDiscriminatorType.Disabled)
            {
                disabled = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ThinkingConfigDisabled>(ref reader, options);
            }
            global::Anthropic.ThinkingConfigAdaptive? adaptive = default;
            if (discriminator?.Type == global::Anthropic.ThinkingConfigParamDiscriminatorType.Adaptive)
            {
                adaptive = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ThinkingConfigAdaptive>(ref reader, options);
            }

            var __value = new global::Anthropic.ThinkingConfigParam(
                discriminator?.Type,
                enabled,

                disabled,

                adaptive
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ThinkingConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEnabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeof(global::Anthropic.ThinkingConfigEnabled), options);
            }
            else if (value.IsDisabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeof(global::Anthropic.ThinkingConfigDisabled), options);
            }
            else if (value.IsAdaptive)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Adaptive, typeof(global::Anthropic.ThinkingConfigAdaptive), options);
            }
        }
    }
}