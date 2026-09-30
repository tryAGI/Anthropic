#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ProviderConfig4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ProviderConfig4>
    {
        /// <inheritdoc />
        public override global::Anthropic.ProviderConfig4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.AwsExternalKeyConfig? aws = default;
            if (discriminator?.Type == global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AwsExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AwsExternalKeyConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.AwsExternalKeyConfig)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.GcpExternalKeyConfig? gcp = default;
            if (discriminator?.Type == global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.GcpExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.GcpExternalKeyConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.GcpExternalKeyConfig)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.AzureExternalKeyConfigParams? azure = default;
            if (discriminator?.Type == global::Anthropic.ExternalKeyCreateParamsProviderConfigDiscriminatorType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AzureExternalKeyConfigParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AzureExternalKeyConfigParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.AzureExternalKeyConfigParams)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ProviderConfig4(
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
            global::Anthropic.ProviderConfig4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AwsExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AwsExternalKeyConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AwsExternalKeyConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAws(), typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.GcpExternalKeyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.GcpExternalKeyConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.GcpExternalKeyConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGcp(), typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AzureExternalKeyConfigParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AzureExternalKeyConfigParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AzureExternalKeyConfigParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAzure(), typeInfo);
            }
        }
    }
}