#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Error>
    {
        /// <inheritdoc />
        public override global::Anthropic.Error Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaErrorResponseErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaErrorResponseErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaErrorResponseErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaInvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaInvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaInvalidRequestError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaInvalidRequestError)}");
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAuthenticationError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAuthenticationError)}");
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaBillingError? billingError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.BillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBillingError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBillingError)}");
                billingError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaPermissionError? permissionError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.PermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPermissionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaPermissionError)}");
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaNotFoundError? notFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaNotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaNotFoundError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaNotFoundError)}");
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitError)}");
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaGatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGatewayTimeoutError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGatewayTimeoutError)}");
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAPIError? apiError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.ApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAPIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAPIError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAPIError)}");
                apiError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaOverloadedError? overloadedError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOverloadedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaOverloadedError)}");
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Error(
                discriminator?.Type,
                invalidRequestError,
                authenticationError,
                billingError,
                permissionError,
                notFoundError,
                rateLimitError,
                timeoutError,
                apiError,
                overloadedError
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Error value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaInvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaInvalidRequestError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaInvalidRequestError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeInfo);
            }
            else if (value.IsAuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAuthenticationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAuthenticationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeInfo);
            }
            else if (value.IsBillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBillingError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBillingError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeInfo);
            }
            else if (value.IsPermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPermissionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaPermissionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeInfo);
            }
            else if (value.IsNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaNotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaNotFoundError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaNotFoundError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeInfo);
            }
            else if (value.IsRateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeInfo);
            }
            else if (value.IsTimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGatewayTimeoutError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGatewayTimeoutError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeInfo);
            }
            else if (value.IsApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAPIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAPIError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAPIError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeInfo);
            }
            else if (value.IsOverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOverloadedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaOverloadedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeInfo);
            }
        }
    }
}