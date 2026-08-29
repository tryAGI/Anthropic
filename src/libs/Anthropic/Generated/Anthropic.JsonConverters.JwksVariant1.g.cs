#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class JwksVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.JwksVariant1>
    {
        /// <inheritdoc />
        public override global::Anthropic.JwksVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaJwksDiscovery? discovery = default;
            if (discriminator?.Type == global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Discovery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaJwksDiscovery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaJwksDiscovery> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaJwksDiscovery)}");
                discovery = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaJwksExplicitUrl? explicitUrl = default;
            if (discriminator?.Type == global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.ExplicitUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaJwksExplicitUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaJwksExplicitUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaJwksExplicitUrl)}");
                explicitUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaJwksInline? inline = default;
            if (discriminator?.Type == global::Anthropic.BetaFederationIssuerUpdateParamsJwksVariant1DiscriminatorType.Inline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaJwksInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaJwksInline> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaJwksInline)}");
                inline = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.JwksVariant1(
                discriminator?.Type,
                discovery,

                explicitUrl,

                inline
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.JwksVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDiscovery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaJwksDiscovery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaJwksDiscovery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaJwksDiscovery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Discovery!, typeInfo);
            }
            else if (value.IsExplicitUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaJwksExplicitUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaJwksExplicitUrl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaJwksExplicitUrl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExplicitUrl!, typeInfo);
            }
            else if (value.IsInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaJwksInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaJwksInline?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaJwksInline).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inline!, typeInfo);
            }
        }
    }
}