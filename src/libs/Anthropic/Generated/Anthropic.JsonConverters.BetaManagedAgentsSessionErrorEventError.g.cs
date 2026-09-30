#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsSessionErrorEventErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsSessionErrorEventError>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsSessionErrorEventError Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsUnknownError? unknownError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.UnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsUnknownError)}");
                unknownError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsModelOverloadedError? modelOverloadedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelOverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsModelOverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsModelOverloadedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsModelOverloadedError)}");
                modelOverloadedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsModelRateLimitedError? modelRateLimitedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelRateLimitedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsModelRateLimitedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsModelRateLimitedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsModelRateLimitedError)}");
                modelRateLimitedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsModelRequestFailedError? modelRequestFailedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.ModelRequestFailedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsModelRequestFailedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsModelRequestFailedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsModelRequestFailedError)}");
                modelRequestFailedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? mcpConnectionFailedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.McpConnectionFailedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError)}");
                mcpConnectionFailedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? mcpAuthenticationFailedError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.McpAuthenticationFailedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError)}");
                mcpAuthenticationFailedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsBillingError? billingError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.BillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsBillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsBillingError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsBillingError)}");
                billingError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? credentialHostUnreachableError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.CredentialHostUnreachableError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError)}");
                credentialHostUnreachableError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? repositoryAuthenticationError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.RepositoryAuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError)}");
                repositoryAuthenticationError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? repositoryForbiddenError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.RepositoryForbiddenError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryForbiddenError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError)}");
                repositoryForbiddenError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? repositoryNotFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.RepositoryNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryNotFoundError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError)}");
                repositoryNotFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? repositoryCheckoutError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.RepositoryCheckoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryCheckoutError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError)}");
                repositoryCheckoutError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsRepositoryCloneError? repositoryCloneError = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType.RepositoryCloneError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryCloneError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryCloneError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsRepositoryCloneError)}");
                repositoryCloneError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsSessionErrorEventError(
                discriminator?.Type,
                unknownError,

                modelOverloadedError,

                modelRateLimitedError,

                modelRequestFailedError,

                mcpConnectionFailedError,

                mcpAuthenticationFailedError,

                billingError,

                credentialHostUnreachableError,

                repositoryAuthenticationError,

                repositoryForbiddenError,

                repositoryNotFoundError,

                repositoryCheckoutError,

                repositoryCloneError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsSessionErrorEventError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnknownError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsUnknownError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsUnknownError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsUnknownError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnknownError(), typeInfo);
            }
            else if (value.IsModelOverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsModelOverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsModelOverloadedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsModelOverloadedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOverloadedError(), typeInfo);
            }
            else if (value.IsModelRateLimitedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsModelRateLimitedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsModelRateLimitedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsModelRateLimitedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelRateLimitedError(), typeInfo);
            }
            else if (value.IsModelRequestFailedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsModelRequestFailedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsModelRequestFailedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsModelRequestFailedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelRequestFailedError(), typeInfo);
            }
            else if (value.IsMcpConnectionFailedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMcpConnectionFailedError(), typeInfo);
            }
            else if (value.IsMcpAuthenticationFailedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMcpAuthenticationFailedError(), typeInfo);
            }
            else if (value.IsBillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsBillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsBillingError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsBillingError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBillingError(), typeInfo);
            }
            else if (value.IsCredentialHostUnreachableError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCredentialHostUnreachableError(), typeInfo);
            }
            else if (value.IsRepositoryAuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepositoryAuthenticationError(), typeInfo);
            }
            else if (value.IsRepositoryForbiddenError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryForbiddenError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepositoryForbiddenError(), typeInfo);
            }
            else if (value.IsRepositoryNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryNotFoundError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepositoryNotFoundError(), typeInfo);
            }
            else if (value.IsRepositoryCheckoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryCheckoutError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepositoryCheckoutError(), typeInfo);
            }
            else if (value.IsRepositoryCloneError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsRepositoryCloneError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsRepositoryCloneError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsRepositoryCloneError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepositoryCloneError(), typeInfo);
            }
        }
    }
}