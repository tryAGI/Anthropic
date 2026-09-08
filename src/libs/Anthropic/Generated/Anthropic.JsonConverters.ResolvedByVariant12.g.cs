#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResolvedByVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ResolvedByVariant12>
    {
        /// <inheritdoc />
        public override global::Anthropic.ResolvedByVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaUserActorSchema? userActor = default;
            if (discriminator?.Type == global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType.UserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaUserActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaUserActorSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaUserActorSchema)}");
                userActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaScopedApiKeyActorSchema? scopedApiKeyActor = default;
            if (discriminator?.Type == global::Anthropic.BetaSpendLimitIncreaseRequestSchemaResolvedByVariant1DiscriminatorType.ScopedApiKeyActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaScopedApiKeyActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaScopedApiKeyActorSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaScopedApiKeyActorSchema)}");
                scopedApiKeyActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ResolvedByVariant12(
                discriminator?.Type,
                userActor,

                scopedApiKeyActor
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ResolvedByVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaUserActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaUserActorSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaUserActorSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserActor!, typeInfo);
            }
            else if (value.IsScopedApiKeyActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaScopedApiKeyActorSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaScopedApiKeyActorSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaScopedApiKeyActorSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScopedApiKeyActor!, typeInfo);
            }
        }
    }
}