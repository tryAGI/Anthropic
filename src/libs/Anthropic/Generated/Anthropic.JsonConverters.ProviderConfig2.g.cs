#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ProviderConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ProviderConfig2>
    {
        /// <inheritdoc />
        public override global::Anthropic.ProviderConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaAwsExternalKeyConfig? aws = default;
            if (discriminator?.Type == global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAwsExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAwsExternalKeyConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAwsExternalKeyConfig)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaGcpExternalKeyConfig? gcp = default;
            if (discriminator?.Type == global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGcpExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGcpExternalKeyConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGcpExternalKeyConfig)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAzureExternalKeyConfigParams? azure = default;
            if (discriminator?.Type == global::Anthropic.BetaExternalKeyCreateParamsProviderConfigDiscriminatorType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAzureExternalKeyConfigParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAzureExternalKeyConfigParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAzureExternalKeyConfigParams)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ProviderConfig2(
                discriminator?.Type,
                aws,

                gcp,

                azure
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ProviderConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAwsExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAwsExternalKeyConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAwsExternalKeyConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Aws!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGcpExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGcpExternalKeyConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGcpExternalKeyConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAzureExternalKeyConfigParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAzureExternalKeyConfigParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAzureExternalKeyConfigParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
        }
    }
}