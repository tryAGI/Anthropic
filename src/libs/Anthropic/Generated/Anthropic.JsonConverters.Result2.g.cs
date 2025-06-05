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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MessageBatchIndividualResponseResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MessageBatchIndividualResponseResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.MessageBatchIndividualResponseResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.SucceededResult? succeeded = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Succeeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SucceededResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SucceededResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SucceededResult)}");
                succeeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ErroredResult? errored = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Errored)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ErroredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ErroredResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ErroredResult)}");
                errored = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.CanceledResult? canceled = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Canceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CanceledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CanceledResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.CanceledResult)}");
                canceled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ExpiredResult? expired = default;
            if (discriminator?.Type == global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType.Expired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ExpiredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ExpiredResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ExpiredResult)}");
                expired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.Result2(
                discriminator?.Type,
                succeeded,
                errored,
                canceled,
                expired
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Result2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSucceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SucceededResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SucceededResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.SucceededResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Succeeded, typeInfo);
            }
            else if (value.IsErrored)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ErroredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ErroredResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ErroredResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Errored, typeInfo);
            }
            else if (value.IsCanceled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.CanceledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.CanceledResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.CanceledResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Canceled, typeInfo);
            }
            else if (value.IsExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ExpiredResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ExpiredResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ExpiredResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expired, typeInfo);
            }
        }
    }
}