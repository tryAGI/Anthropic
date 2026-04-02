#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Result2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Result2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Result2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.MessageBatchIndividualResponseResultDiscriminator>(ref readerCopy, options);

            global::Anthropic.SucceededResult? succeeded = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Succeeded)
            {
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.SucceededResult>(ref reader, options);
            }
            global::Anthropic.ErroredResult? errored = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Errored)
            {
                errored = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ErroredResult>(ref reader, options);
            }
            global::Anthropic.CanceledResult? canceled = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Canceled)
            {
                canceled = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.CanceledResult>(ref reader, options);
            }
            global::Anthropic.ExpiredResult? expired = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Expired)
            {
                expired = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ExpiredResult>(ref reader, options);
            }

            var __value = new global::Anthropic.Result2(
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
            global::Anthropic.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSucceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeof(global::Anthropic.SucceededResult), options);
            }
            else if (value.IsErrored)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeof(global::Anthropic.ErroredResult), options);
            }
            else if (value.IsCanceled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeof(global::Anthropic.CanceledResult), options);
            }
            else if (value.IsExpired)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeof(global::Anthropic.ExpiredResult), options);
            }
        }
    }
}