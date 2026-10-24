#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaAnalyticsReportActorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaAnalyticsReportActor>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaAnalyticsReportActor Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsReportActorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsReportActorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsReportActorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaAnalyticsReportUserActor? userActor = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsReportActorDiscriminatorType.UserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsReportUserActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsReportUserActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsReportUserActor)}");
                userActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAnalyticsServiceAccountActor? serviceAccountActor = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsReportActorDiscriminatorType.ServiceAccountActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsServiceAccountActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsServiceAccountActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsServiceAccountActor)}");
                serviceAccountActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAnalyticsFederatedActor? federatedActor = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsReportActorDiscriminatorType.FederatedActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsFederatedActor)}");
                federatedActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAnalyticsApiActor? apiActor = default;
            if (discriminator?.Type == global::Anthropic.BetaAnalyticsReportActorDiscriminatorType.ApiActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsApiActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsApiActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAnalyticsApiActor)}");
                apiActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaAnalyticsReportActor(
                discriminator?.Type,
                userActor,

                serviceAccountActor,

                federatedActor,

                apiActor
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaAnalyticsReportActor value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsUserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsReportUserActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsReportUserActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsReportUserActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserActor(), typeInfo);
            }
            else if (value.IsServiceAccountActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsServiceAccountActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsServiceAccountActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsServiceAccountActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickServiceAccountActor(), typeInfo);
            }
            else if (value.IsFederatedActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsFederatedActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsFederatedActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsFederatedActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFederatedActor(), typeInfo);
            }
            else if (value.IsApiActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAnalyticsApiActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAnalyticsApiActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAnalyticsApiActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApiActor(), typeInfo);
            }
        }
    }
}