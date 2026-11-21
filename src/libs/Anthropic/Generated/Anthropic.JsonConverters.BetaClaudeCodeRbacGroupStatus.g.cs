#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeCodeRbacGroupStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeCodeRbacGroupStatus>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeCodeRbacGroupStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? active = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType.Active)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusActive> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive)}");
                active = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? deleted = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType.Deleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted)}");
                deleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? unknown = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeCodeRbacGroupStatus(
                discriminator?.Type,
                active,

                deleted,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeCodeRbacGroupStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsActive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusActive?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickActive(), typeInfo);
            }
            else if (value.IsDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDeleted(), typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnknown(), typeInfo);
            }
        }
    }
}