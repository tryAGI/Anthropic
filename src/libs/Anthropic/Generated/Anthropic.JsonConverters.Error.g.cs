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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaErrorResponseErrorDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaInvalidRequestError? invalidRequestError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.InvalidRequestError)
            {
                invalidRequestError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaInvalidRequestError>(ref reader, options);
            }
            global::Anthropic.BetaAuthenticationError? authenticationError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.AuthenticationError)
            {
                authenticationError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaAuthenticationError>(ref reader, options);
            }
            global::Anthropic.BetaBillingError? billingError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.BillingError)
            {
                billingError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaBillingError>(ref reader, options);
            }
            global::Anthropic.BetaPermissionError? permissionError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.PermissionError)
            {
                permissionError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaPermissionError>(ref reader, options);
            }
            global::Anthropic.BetaNotFoundError? notFoundError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.NotFoundError)
            {
                notFoundError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaNotFoundError>(ref reader, options);
            }
            global::Anthropic.BetaRateLimitError? rateLimitError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.RateLimitError)
            {
                rateLimitError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRateLimitError>(ref reader, options);
            }
            global::Anthropic.BetaGatewayTimeoutError? timeoutError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.TimeoutError)
            {
                timeoutError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaGatewayTimeoutError>(ref reader, options);
            }
            global::Anthropic.BetaAPIError? apiError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.ApiError)
            {
                apiError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaAPIError>(ref reader, options);
            }
            global::Anthropic.BetaOverloadedError? overloadedError = default;
            if (discriminator?.Type == global::Anthropic.BetaErrorResponseErrorDiscriminatorType.OverloadedError)
            {
                overloadedError = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaOverloadedError>(ref reader, options);
            }

            var __value = new global::Anthropic.Error(
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
            global::Anthropic.Error value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInvalidRequestError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InvalidRequestError, typeof(global::Anthropic.BetaInvalidRequestError), options);
            }
            else if (value.IsAuthenticationError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthenticationError, typeof(global::Anthropic.BetaAuthenticationError), options);
            }
            else if (value.IsBillingError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError, typeof(global::Anthropic.BetaBillingError), options);
            }
            else if (value.IsPermissionError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PermissionError, typeof(global::Anthropic.BetaPermissionError), options);
            }
            else if (value.IsNotFoundError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotFoundError, typeof(global::Anthropic.BetaNotFoundError), options);
            }
            else if (value.IsRateLimitError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitError, typeof(global::Anthropic.BetaRateLimitError), options);
            }
            else if (value.IsTimeoutError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimeoutError, typeof(global::Anthropic.BetaGatewayTimeoutError), options);
            }
            else if (value.IsApiError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiError, typeof(global::Anthropic.BetaAPIError), options);
            }
            else if (value.IsOverloadedError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverloadedError, typeof(global::Anthropic.BetaOverloadedError), options);
            }
        }
    }
}