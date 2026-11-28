#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaGoogleManagedStorageRegionStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaGoogleManagedStorageRegionStatus>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaGoogleManagedStorageRegionStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? notConfigured = default;
            if (discriminator?.Type == global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType.NotConfigured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured)}");
                notConfigured = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaGoogleManagedStorageRegionPending? pending = default;
            if (discriminator?.Type == global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType.Pending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionPending> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGoogleManagedStorageRegionPending)}");
                pending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaGoogleManagedStorageRegionActive? active = default;
            if (discriminator?.Type == global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType.Active)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionActive> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGoogleManagedStorageRegionActive)}");
                active = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaGoogleManagedStorageRegionFailed? failed = default;
            if (discriminator?.Type == global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGoogleManagedStorageRegionFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaGoogleManagedStorageRegionSuspended? suspended = default;
            if (discriminator?.Type == global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType.Suspended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionSuspended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionSuspended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaGoogleManagedStorageRegionSuspended)}");
                suspended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaGoogleManagedStorageRegionStatus(
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
            global::Anthropic.BetaGoogleManagedStorageRegionStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsNotConfigured)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNotConfigured(), typeInfo);
            }
            else if (value.IsPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionPending?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGoogleManagedStorageRegionPending).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPending(), typeInfo);
            }
            else if (value.IsActive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionActive?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGoogleManagedStorageRegionActive).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickActive(), typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGoogleManagedStorageRegionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFailed(), typeInfo);
            }
            else if (value.IsSuspended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaGoogleManagedStorageRegionSuspended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaGoogleManagedStorageRegionSuspended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaGoogleManagedStorageRegionSuspended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSuspended(), typeInfo);
            }
        }
    }
}