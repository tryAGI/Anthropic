#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaTelemetryDestinationDisabledReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaTelemetryDestinationDisabledReason>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaTelemetryDestinationDisabledReason Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? caller = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType.Caller)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller)}");
                caller = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? sustainedFailure = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType.SustainedFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure)}");
                sustainedFailure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? invalidAddress = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType.InvalidAddress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress)}");
                invalidAddress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? redirect = default;
            if (discriminator?.Type == global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType.Redirect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect)}");
                redirect = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaTelemetryDestinationDisabledReason(
                discriminator?.Type,
                caller,

                sustainedFailure,

                invalidAddress,

                redirect
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaTelemetryDestinationDisabledReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsCaller)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCaller(), typeInfo);
            }
            else if (value.IsSustainedFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSustainedFailure(), typeInfo);
            }
            else if (value.IsInvalidAddress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInvalidAddress(), typeInfo);
            }
            else if (value.IsRedirect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRedirect(), typeInfo);
            }
        }
    }
}