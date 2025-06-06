#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Error2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Error2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Error2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ErrorResponseErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ErrorResponseErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ErrorResponseErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.InvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.InvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.InvalidRequestError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.InvalidRequestError)}");
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.AuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AuthenticationError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.AuthenticationError)}");
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BillingError? billingError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.BillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BillingError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BillingError)}");
                billingError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.PermissionError? permissionError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.PermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.PermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.PermissionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.PermissionError)}");
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.NotFoundError? notFoundError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.NotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.NotFoundError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.NotFoundError)}");
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitError)}");
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.GatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.GatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.GatewayTimeoutError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.GatewayTimeoutError)}");
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.APIError? apiError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.ApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.APIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.APIError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.APIError)}");
                apiError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.OverloadedError? overloadedError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OverloadedError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.OverloadedError)}");
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Error2(
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
            global::Anthropic.Error2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInvalidRequestError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.InvalidRequestError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.InvalidRequestError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.InvalidRequestError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeInfo);
            }
            else if (value.IsAuthenticationError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AuthenticationError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AuthenticationError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AuthenticationError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeInfo);
            }
            else if (value.IsBillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BillingError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BillingError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeInfo);
            }
            else if (value.IsPermissionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.PermissionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.PermissionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.PermissionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeInfo);
            }
            else if (value.IsNotFoundError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.NotFoundError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.NotFoundError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.NotFoundError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeInfo);
            }
            else if (value.IsRateLimitError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeInfo);
            }
            else if (value.IsTimeoutError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.GatewayTimeoutError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.GatewayTimeoutError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.GatewayTimeoutError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeInfo);
            }
            else if (value.IsApiError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.APIError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.APIError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.APIError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeInfo);
            }
            else if (value.IsOverloadedError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OverloadedError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OverloadedError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.OverloadedError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeInfo);
            }
        }
    }
}