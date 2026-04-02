#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaIterationsUsageVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaIterationsUsageVariant1Item>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaIterationsUsageVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaIterationsUsageVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaMessageIterationUsage? message = default;
            if (discriminator?.Type == global::Anthropic.BetaIterationsUsageVariant1ItemDiscriminatorType.Message)
            {
                message = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMessageIterationUsage>(ref reader, options);
            }
            global::Anthropic.BetaCompactionIterationUsage? compaction = default;
            if (discriminator?.Type == global::Anthropic.BetaIterationsUsageVariant1ItemDiscriminatorType.Compaction)
            {
                compaction = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaCompactionIterationUsage>(ref reader, options);
            }

            var __value = new global::Anthropic.BetaIterationsUsageVariant1Item(
                discriminator?.Type,
                message,

                compaction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaIterationsUsageVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeof(global::Anthropic.BetaMessageIterationUsage), options);
            }
            else if (value.IsCompaction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeof(global::Anthropic.BetaCompactionIterationUsage), options);
            }
        }
    }
}