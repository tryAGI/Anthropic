#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class UserProfileActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.UserProfileAction>
    {
        /// <inheritdoc />
        public override global::Anthropic.UserProfileAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileActionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileActionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserProfileActionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.UserProfileEnrollEndUserAction? enrollEndUser = default;
            if (discriminator?.Type == global::Anthropic.UserProfileActionDiscriminatorType.EnrollEndUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnrollEndUserAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnrollEndUserAction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserProfileEnrollEndUserAction)}");
                enrollEndUser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.UserProfileAction(
                discriminator?.Type,
                enrollEndUser
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.UserProfileAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsEnrollEndUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnrollEndUserAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnrollEndUserAction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UserProfileEnrollEndUserAction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEnrollEndUser(), typeInfo);
            }
        }
    }
}