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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ToolChoiceDiscriminator>(ref readerCopy, options);

            global::Anthropic.ToolChoiceAuto? auto = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.Auto)
            {
                auto = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ToolChoiceAuto>(ref reader, options);
            }
            global::Anthropic.ToolChoiceAny? any = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.Any)
            {
                any = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ToolChoiceAny>(ref reader, options);
            }
            global::Anthropic.ToolChoiceTool? tool = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ToolChoiceTool>(ref reader, options);
            }
            global::Anthropic.ToolChoiceNone? none = default;
            if (discriminator?.Type == global::Anthropic.ToolChoiceDiscriminatorType.None)
            {
                none = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ToolChoiceNone>(ref reader, options);
            }

            var __value = new global::Anthropic.ToolChoice(
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
            global::Anthropic.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAuto)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeof(global::Anthropic.ToolChoiceAuto), options);
            }
            else if (value.IsAny)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Any, typeof(global::Anthropic.ToolChoiceAny), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::Anthropic.ToolChoiceTool), options);
            }
            else if (value.IsNone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeof(global::Anthropic.ToolChoiceNone), options);
            }
        }
    }
}