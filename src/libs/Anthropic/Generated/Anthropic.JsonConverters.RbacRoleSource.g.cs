#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class RbacRoleSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.RbacRoleSource>
    {
        /// <inheritdoc />
        public override global::Anthropic.RbacRoleSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacRoleSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacRoleSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RbacRoleSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.RbacRoleSourceBuiltIn? builtIn = default;
            if (discriminator?.Type == global::Anthropic.RbacRoleSourceDiscriminatorType.BuiltIn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacRoleSourceBuiltIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacRoleSourceBuiltIn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RbacRoleSourceBuiltIn)}");
                builtIn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RbacRoleSourceCustom? custom = default;
            if (discriminator?.Type == global::Anthropic.RbacRoleSourceDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacRoleSourceCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacRoleSourceCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RbacRoleSourceCustom)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.RbacRoleSource(
                discriminator?.Type,
                builtIn,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.RbacRoleSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsBuiltIn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacRoleSourceBuiltIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacRoleSourceBuiltIn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RbacRoleSourceBuiltIn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBuiltIn(), typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacRoleSourceCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacRoleSourceCustom?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RbacRoleSourceCustom).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustom(), typeInfo);
            }
        }
    }
}