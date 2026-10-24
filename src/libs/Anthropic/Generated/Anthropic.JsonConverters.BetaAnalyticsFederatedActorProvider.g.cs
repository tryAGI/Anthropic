#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaAnalyticsFederatedActorProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaAnalyticsFederatedActorProvider>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaAnalyticsFederatedActorProvider Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaAnalyticsFederatedActorAwsProvider? aws = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType.Aws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorAwsProvider> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider)}");
                aws = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAnalyticsFederatedActorAzureProvider? azure = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorAzureProvider> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAnalyticsFederatedActorGcpProvider? gcp = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorGcpProvider> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAnalyticsFederatedActorOidcProvider? oidc = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsFederatedActorProviderDiscriminatorType.Oidc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorOidcProvider> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider)}");
                oidc = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaAnalyticsFederatedActorProvider(
                discriminator?.Type,
                aws,

                azure,

                gcp,

                oidc
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaAnalyticsFederatedActorProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorAwsProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsFederatedActorAwsProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAws(), typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorAzureProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsFederatedActorAzureProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAzure(), typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorGcpProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsFederatedActorGcpProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGcp(), typeInfo);
            }
            else if (value.IsOidc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActorOidcProvider?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsFederatedActorOidcProvider).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOidc(), typeInfo);
            }
        }
    }
}