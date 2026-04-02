#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaThinkingConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaThinkingConfigParam>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaThinkingConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaThinkingConfigParamDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaThinkingConfigEnabled? enabled = default;
            if (discriminator?.Type == global::Anthropic.BetaThinkingConfigParamDiscriminatorType.Enabled)
            {
                enabled = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaThinkingConfigEnabled>(ref reader, options);
            }
            global::Anthropic.BetaThinkingConfigDisabled? disabled = default;
            if (discriminator?.Type == global::Anthropic.BetaThinkingConfigParamDiscriminatorType.Disabled)
            {
                disabled = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaThinkingConfigDisabled>(ref reader, options);
            }
            global::Anthropic.BetaThinkingConfigAdaptive? adaptive = default;
            if (discriminator?.Type == global::Anthropic.BetaThinkingConfigParamDiscriminatorType.Adaptive)
            {
                adaptive = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaThinkingConfigAdaptive>(ref reader, options);
            }

            var __value = new global::Anthropic.BetaThinkingConfigParam(
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
            global::Anthropic.BetaThinkingConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEnabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enabled, typeof(global::Anthropic.BetaThinkingConfigEnabled), options);
            }
            else if (value.IsDisabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeof(global::Anthropic.BetaThinkingConfigDisabled), options);
            }
            else if (value.IsAdaptive)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Adaptive, typeof(global::Anthropic.BetaThinkingConfigAdaptive), options);
            }
        }
    }
}