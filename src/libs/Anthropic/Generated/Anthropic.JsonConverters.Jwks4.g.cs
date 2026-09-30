#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Jwks4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Jwks4>
    {
        /// <inheritdoc />
        public override global::Anthropic.Jwks4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.FederationIssuerCreateParamsJwksDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.JwksDiscovery? discovery = default;
            if (discriminator?.Type == global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType.Discovery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.JwksDiscovery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.JwksDiscovery> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.JwksDiscovery)}");
                discovery = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.JwksExplicitUrl? explicitUrl = default;
            if (discriminator?.Type == global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType.ExplicitUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.JwksExplicitUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.JwksExplicitUrl> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.JwksExplicitUrl)}");
                explicitUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.JwksInline? inline = default;
            if (discriminator?.Type == global::Anthropic.FederationIssuerCreateParamsJwksDiscriminatorType.Inline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.JwksInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.JwksInline> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.JwksInline)}");
                inline = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Jwks4(
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
            global::Anthropic.Jwks4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDiscovery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.JwksDiscovery), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.JwksDiscovery?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.JwksDiscovery).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDiscovery(), typeInfo);
            }
            else if (value.IsExplicitUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.JwksExplicitUrl), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.JwksExplicitUrl?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.JwksExplicitUrl).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickExplicitUrl(), typeInfo);
            }
            else if (value.IsInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.JwksInline), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.JwksInline?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.JwksInline).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInline(), typeInfo);
            }
        }
    }
}