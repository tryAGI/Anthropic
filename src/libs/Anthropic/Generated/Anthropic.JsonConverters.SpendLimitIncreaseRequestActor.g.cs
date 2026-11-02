#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class SpendLimitIncreaseRequestActorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.SpendLimitIncreaseRequestActor>
    {
        /// <inheritdoc />
        public override global::Anthropic.SpendLimitIncreaseRequestActor Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SpendLimitIncreaseRequestActorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SpendLimitIncreaseRequestActorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SpendLimitIncreaseRequestActorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.UserActorSchema? userActor = default;
            if (discriminator?.Type == global::Anthropic.SpendLimitIncreaseRequestActorDiscriminatorType.UserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserActorSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserActorSchema)}");
                userActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ScopedApiKeyActorSchema? scopedApiKeyActor = default;
            if (discriminator?.Type == global::Anthropic.SpendLimitIncreaseRequestActorDiscriminatorType.ScopedApiKeyActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ScopedApiKeyActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ScopedApiKeyActorSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ScopedApiKeyActorSchema)}");
                scopedApiKeyActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.SpendLimitIncreaseRequestActor(
                discriminator?.Type,
                userActor,

                scopedApiKeyActor
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.SpendLimitIncreaseRequestActor value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsUserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserActorSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UserActorSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserActor(), typeInfo);
            }
            else if (value.IsScopedApiKeyActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ScopedApiKeyActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ScopedApiKeyActorSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ScopedApiKeyActorSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScopedApiKeyActor(), typeInfo);
            }
        }
    }
}