#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaToolChoice>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaToolChoiceDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::Anthropic.BetaToolChoiceDiscriminatorType.Auto)
            {
                auto = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaToolChoiceAuto>(ref reader, options);
            }
            global::Anthropic.BetaToolChoiceAny? any = default;
            if (discriminator?.Type == global::Anthropic.BetaToolChoiceDiscriminatorType.Any)
            {
                any = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaToolChoiceAny>(ref reader, options);
            }
            global::Anthropic.BetaToolChoiceTool? tool = default;
            if (discriminator?.Type == global::Anthropic.BetaToolChoiceDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaToolChoiceTool>(ref reader, options);
            }
            global::Anthropic.BetaToolChoiceNone? none = default;
            if (discriminator?.Type == global::Anthropic.BetaToolChoiceDiscriminatorType.None)
            {
                none = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaToolChoiceNone>(ref reader, options);
            }

            var __value = new global::Anthropic.BetaToolChoice(
                discriminator?.Type,
                auto,

                any,

                tool,

                none
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAuto)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeof(global::Anthropic.BetaToolChoiceAuto), options);
            }
            else if (value.IsAny)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeof(global::Anthropic.BetaToolChoiceAny), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::Anthropic.BetaToolChoiceTool), options);
            }
            else if (value.IsNone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeof(global::Anthropic.BetaToolChoiceNone), options);
            }
        }
    }
}