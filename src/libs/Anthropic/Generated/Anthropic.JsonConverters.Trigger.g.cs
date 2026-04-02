#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class TriggerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Trigger>
    {
        /// <inheritdoc />
        public override global::Anthropic.Trigger Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaClearToolUses20250919TriggerDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaInputTokensTrigger? inputTokens = default;
            if (discriminator?.Type == global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType.InputTokens)
            {
                inputTokens = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaInputTokensTrigger>(ref reader, options);
            }
            global::Anthropic.BetaToolUsesTrigger? toolUses = default;
            if (discriminator?.Type == global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType.ToolUses)
            {
                toolUses = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaToolUsesTrigger>(ref reader, options);
            }

            var __value = new global::Anthropic.Trigger(
                discriminator?.Type,
                inputTokens,

                toolUses
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Trigger value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputTokens)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputTokens, typeof(global::Anthropic.BetaInputTokensTrigger), options);
            }
            else if (value.IsToolUses)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUses, typeof(global::Anthropic.BetaToolUsesTrigger), options);
            }
        }
    }
}