#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeTagCreateBundleTargetRequestBodyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate? slackChannel = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType.SlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate)}");
                slackChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate? slackWorkspace = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBodyDiscriminatorType.SlackWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate)}");
                slackWorkspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody(
                discriminator?.Type,
                slackChannel,

                slackWorkspace
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeTagCreateBundleTargetRequestBody value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsSlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTargetCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackChannel(), typeInfo);
            }
            else if (value.IsSlackWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTargetCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackWorkspace(), typeInfo);
            }
        }
    }
}