#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Result>
    {
        /// <inheritdoc />
        public override global::Anthropic.Result Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaSucceededResult? succeeded = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType.Succeeded)
            {
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaSucceededResult>(ref reader, options);
            }
            global::Anthropic.BetaErroredResult? errored = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType.Errored)
            {
                errored = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaErroredResult>(ref reader, options);
            }
            global::Anthropic.BetaCanceledResult? canceled = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType.Canceled)
            {
                canceled = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaCanceledResult>(ref reader, options);
            }
            global::Anthropic.BetaExpiredResult? expired = default;
            if (discriminator?.Type == global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType.Expired)
            {
                expired = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaExpiredResult>(ref reader, options);
            }

            var __value = new global::Anthropic.Result(
                discriminator?.Type,
                succeeded,

                errored,

                canceled,

                expired
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Result value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSucceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeof(global::Anthropic.BetaSucceededResult), options);
            }
            else if (value.IsErrored)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeof(global::Anthropic.BetaErroredResult), options);
            }
            else if (value.IsCanceled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeof(global::Anthropic.BetaCanceledResult), options);
            }
            else if (value.IsExpired)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeof(global::Anthropic.BetaExpiredResult), options);
            }
        }
    }
}