#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class PrincipalVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.PrincipalVariant12>
    {
        /// <inheritdoc />
        public override global::Anthropic.PrincipalVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyPrincipalVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyPrincipalVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ApiKeyPrincipalVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ApiKeyUserActor? userActor = default;
            if (discriminator?.Type == global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType.UserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyUserActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyUserActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ApiKeyUserActor)}");
                userActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ApiKeyServiceAccountActor? serviceAccountActor = default;
            if (discriminator?.Type == global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType.ServiceAccountActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyServiceAccountActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyServiceAccountActor> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ApiKeyServiceAccountActor)}");
                serviceAccountActor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.PrincipalVariant12(
                discriminator?.Type,
                userActor,

                serviceAccountActor
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.PrincipalVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyUserActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyUserActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ApiKeyUserActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUserActor(), typeInfo);
            }
            else if (value.IsServiceAccountActor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyServiceAccountActor), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyServiceAccountActor?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ApiKeyServiceAccountActor).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickServiceAccountActor(), typeInfo);
            }
        }
    }
}