#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Status4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Status4>
    {
        /// <inheritdoc />
        public override global::Anthropic.Status4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageControlEnabledStatusDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageControlEnabledStatusDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaStorageControlEnabledStatusDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaStorageRegionNotConfigured? notConfigured = default;
            if (discriminator?.Type == global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType.NotConfigured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionNotConfigured), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionNotConfigured> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaStorageRegionNotConfigured)}");
                notConfigured = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaStorageRegionPending? pending = default;
            if (discriminator?.Type == global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType.Pending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionPending> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaStorageRegionPending)}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaStorageRegionActive? active = default;
            if (discriminator?.Type == global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType.Active)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionActive> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaStorageRegionActive)}");
                active = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaStorageRegionFailed? failed = default;
            if (discriminator?.Type == global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaStorageRegionFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaStorageRegionSuspended? suspended = default;
            if (discriminator?.Type == global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType.Suspended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionSuspended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionSuspended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaStorageRegionSuspended)}");
                suspended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Status4(
                discriminator?.Type,
                notConfigured,

                pending,

                active,

                failed,

                suspended
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Status4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsNotConfigured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionNotConfigured), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionNotConfigured?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaStorageRegionNotConfigured).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNotConfigured(), typeInfo);
            }
            else if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionPending?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaStorageRegionPending).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPending(), typeInfo);
            }
            else if (value.IsActive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionActive?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaStorageRegionActive).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickActive(), typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaStorageRegionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFailed(), typeInfo);
            }
            else if (value.IsSuspended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaStorageRegionSuspended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaStorageRegionSuspended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaStorageRegionSuspended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSuspended(), typeInfo);
            }
        }
    }
}