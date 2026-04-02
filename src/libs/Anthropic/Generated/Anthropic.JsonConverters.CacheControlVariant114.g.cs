#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant114JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CacheControlVariant114>
    {
        /// <inheritdoc />
        public override global::Anthropic.CacheControlVariant114 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1Discriminator>(ref readerCopy, options);

            global::Anthropic.BetaCacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestBashCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType.Ephemeral)
            {
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaCacheControlEphemeral>(ref reader, options);
            }

            var __value = new global::Anthropic.CacheControlVariant114(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CacheControlVariant114 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEphemeral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ephemeral, typeof(global::Anthropic.BetaCacheControlEphemeral), options);
            }
        }
    }
}