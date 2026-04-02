#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant151JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CacheControlVariant151>
    {
        /// <inheritdoc />
        public override global::Anthropic.CacheControlVariant151 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1Discriminator>(ref readerCopy, options);

            global::Anthropic.CacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::Anthropic.RequestCodeExecutionToolResultBlockCacheControlVariant1DiscriminatorType.Ephemeral)
            {
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.CacheControlEphemeral>(ref reader, options);
            }

            var __value = new global::Anthropic.CacheControlVariant151(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CacheControlVariant151 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEphemeral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ephemeral, typeof(global::Anthropic.CacheControlEphemeral), options);
            }
        }
    }
}