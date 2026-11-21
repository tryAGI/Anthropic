#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeTagReplyModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeTagReplyMode>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeTagReplyMode Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagReplyModeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeTagReplyModeAutomatic? automatic = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType.Automatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeAutomatic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeAutomatic> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagReplyModeAutomatic)}");
                automatic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagReplyModeMentionOnly? mentionOnly = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType.MentionOnly)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeMentionOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeMentionOnly> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagReplyModeMentionOnly)}");
                mentionOnly = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake? alwaysAwake = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType.AlwaysAwake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake)}");
                alwaysAwake = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagReplyModeThread? thread = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagReplyModeDiscriminatorType.Thread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeThread), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeThread> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagReplyModeThread)}");
                thread = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeTagReplyMode(
                discriminator?.Type,
                automatic,

                mentionOnly,

                alwaysAwake,

                thread
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeTagReplyMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAutomatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeAutomatic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeAutomatic?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagReplyModeAutomatic).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutomatic(), typeInfo);
            }
            else if (value.IsMentionOnly)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeMentionOnly), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeMentionOnly?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagReplyModeMentionOnly).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMentionOnly(), typeInfo);
            }
            else if (value.IsAlwaysAwake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagReplyModeAlwaysAwake).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAlwaysAwake(), typeInfo);
            }
            else if (value.IsThread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagReplyModeThread), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagReplyModeThread?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagReplyModeThread).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickThread(), typeInfo);
            }
        }
    }
}