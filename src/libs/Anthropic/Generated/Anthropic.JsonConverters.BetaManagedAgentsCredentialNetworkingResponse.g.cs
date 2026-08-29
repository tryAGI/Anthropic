#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsCredentialNetworkingResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? unrestricted = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType.Unrestricted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse)}");
                unrestricted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? limited = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType.Limited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse)}");
                limited = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse(
                discriminator?.Type,
                unrestricted,

                limited
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsCredentialNetworkingResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnrestricted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unrestricted!, typeInfo);
            }
            else if (value.IsLimited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Limited!, typeInfo);
            }
        }
    }
}