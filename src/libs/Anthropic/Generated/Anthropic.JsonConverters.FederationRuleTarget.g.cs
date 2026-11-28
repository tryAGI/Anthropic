#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class FederationRuleTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.FederationRuleTarget>
    {
        /// <inheritdoc />
        public override global::Anthropic.FederationRuleTarget Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.FederationRuleTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.FederationRuleTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.FederationRuleTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ServiceAccountTarget? serviceAccount = default;
            if (discriminator?.Type == global::Anthropic.FederationRuleTargetDiscriminatorType.ServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ServiceAccountTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ServiceAccountTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ServiceAccountTarget)}");
                serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.FederationRuleTarget(
                discriminator?.Type,
                serviceAccount
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.FederationRuleTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ServiceAccountTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ServiceAccountTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ServiceAccountTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickServiceAccount(), typeInfo);
            }
        }
    }
}