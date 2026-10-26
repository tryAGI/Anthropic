#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class UserProfileEnforcementActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.UserProfileEnforcementAction>
    {
        /// <inheritdoc />
        public override global::Anthropic.UserProfileEnforcementAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnforcementActionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnforcementActionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserProfileEnforcementActionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.UserProfileEnforcementActionRestriction? restriction = default;
            if (discriminator?.Type == global::Anthropic.UserProfileEnforcementActionDiscriminatorType.Restriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnforcementActionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnforcementActionRestriction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserProfileEnforcementActionRestriction)}");
                restriction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.UserProfileEnforcementActionBan? ban = default;
            if (discriminator?.Type == global::Anthropic.UserProfileEnforcementActionDiscriminatorType.Ban)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnforcementActionBan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnforcementActionBan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserProfileEnforcementActionBan)}");
                ban = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.UserProfileEnforcementAction(
                discriminator?.Type,
                restriction,

                ban
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.UserProfileEnforcementAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsRestriction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnforcementActionRestriction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnforcementActionRestriction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UserProfileEnforcementActionRestriction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRestriction(), typeInfo);
            }
            else if (value.IsBan)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserProfileEnforcementActionBan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserProfileEnforcementActionBan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UserProfileEnforcementActionBan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBan(), typeInfo);
            }
        }
    }
}