#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class CacheControlVariant130JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CacheControlVariant130>
    {
        /// <inheritdoc />
        public override global::Anthropic.CacheControlVariant130 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaCacheControlEphemeral? ephemeral = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestWebFetchToolResultBlockCacheControlVariant1DiscriminatorType.Ephemeral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheControlEphemeral), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheControlEphemeral> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCacheControlEphemeral)}");
                ephemeral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.CacheControlVariant130(
                discriminator?.Type,
                ephemeral
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CacheControlVariant130 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEphemeral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCacheControlEphemeral), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCacheControlEphemeral?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCacheControlEphemeral).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ephemeral!, typeInfo);
            }
        }
    }
}