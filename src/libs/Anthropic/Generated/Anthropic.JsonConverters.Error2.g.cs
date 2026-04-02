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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ErrorResponseErrorDiscriminator>(ref readerCopy, options);

            global::Anthropic.InvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.InvalidRequestError>(ref reader, options);
            }
            global::Anthropic.AuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.AuthenticationError>(ref reader, options);
            }
            global::Anthropic.BillingError? billingError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.BillingError)
            {
                billingError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BillingError>(ref reader, options);
            }
            global::Anthropic.PermissionError? permissionError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.PermissionError)
            {
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.PermissionError>(ref reader, options);
            }
            global::Anthropic.NotFoundError? notFoundError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.NotFoundError>(ref reader, options);
            }
            global::Anthropic.RateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RateLimitError>(ref reader, options);
            }
            global::Anthropic.GatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.GatewayTimeoutError>(ref reader, options);
            }
            global::Anthropic.APIError? apiError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.ApiError)
            {
                apiError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.APIError>(ref reader, options);
            }
            global::Anthropic.OverloadedError? overloadedError = default;
            if (discriminator?.Type == global::Anthropic.ErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.OverloadedError>(ref reader, options);
            }

            var __value = new global::Anthropic.Error2(
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Error2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInvalidRequestError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeof(global::Anthropic.InvalidRequestError), options);
            }
            else if (value.IsAuthenticationError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeof(global::Anthropic.AuthenticationError), options);
            }
            else if (value.IsBillingError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeof(global::Anthropic.BillingError), options);
            }
            else if (value.IsPermissionError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeof(global::Anthropic.PermissionError), options);
            }
            else if (value.IsNotFoundError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeof(global::Anthropic.NotFoundError), options);
            }
            else if (value.IsRateLimitError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeof(global::Anthropic.RateLimitError), options);
            }
            else if (value.IsTimeoutError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeof(global::Anthropic.GatewayTimeoutError), options);
            }
            else if (value.IsApiError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeof(global::Anthropic.APIError), options);
            }
            else if (value.IsOverloadedError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeof(global::Anthropic.OverloadedError), options);
            }
        }
    }
}