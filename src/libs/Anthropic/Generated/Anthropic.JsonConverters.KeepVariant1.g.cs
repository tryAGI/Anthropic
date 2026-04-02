#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class KeepVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.KeepVariant1>
    {
        /// <inheritdoc />
        public override global::Anthropic.KeepVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaClearThinking20251015KeepVariant1Discriminator>(ref readerCopy, options);

            global::Anthropic.BetaThinkingTurns? thinkingTurns = default;
            if (discriminator?.Type == global::Anthropic.BetaClearThinking20251015KeepVariant1DiscriminatorType.ThinkingTurns)
            {
                thinkingTurns = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaThinkingTurns>(ref reader, options);
            }
            global::Anthropic.BetaAllThinkingTurns? all = default;
            if (discriminator?.Type == global::Anthropic.BetaClearThinking20251015KeepVariant1DiscriminatorType.All)
            {
                all = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaAllThinkingTurns>(ref reader, options);
            }

            var __value = new global::Anthropic.KeepVariant1(
                discriminator?.Type,
                thinkingTurns,

                all
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.KeepVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsThinkingTurns)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingTurns, typeof(global::Anthropic.BetaThinkingTurns), options);
            }
            else if (value.IsAll)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.All, typeof(global::Anthropic.BetaAllThinkingTurns), options);
            }
        }
    }
}