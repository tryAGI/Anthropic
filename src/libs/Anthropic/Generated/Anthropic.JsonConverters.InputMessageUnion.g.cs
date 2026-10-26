#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class InputMessageUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.InputMessageUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.InputMessageUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.InputMessageUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.InputMessageUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.InputMessageUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.UserInputMessage? user = default;
            if (discriminator?.Role == global::Anthropic.InputMessageUnionDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserInputMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.AssistantInputMessage? assistant = default;
            if (discriminator?.Role == global::Anthropic.InputMessageUnionDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AssistantInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AssistantInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.AssistantInputMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.SystemInputMessage? system = default;
            if (discriminator?.Role == global::Anthropic.InputMessageUnionDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SystemInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SystemInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SystemInputMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.InputMessageUnion(
                discriminator?.Role,
                user,

                assistant,

                system
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.InputMessageUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UserInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUser(), typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AssistantInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AssistantInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AssistantInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAssistant(), typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SystemInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SystemInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.SystemInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSystem(), typeInfo);
            }
        }
    }
}