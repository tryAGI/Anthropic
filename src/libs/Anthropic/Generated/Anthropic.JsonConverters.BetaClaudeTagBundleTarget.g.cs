#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeTagBundleTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeTagBundleTarget>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeTagBundleTarget Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagBundleTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagBundleTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagBundleTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeTagSlackChannelBundleTarget? slackChannel = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType.SlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackChannelBundleTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget)}");
                slackChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget? slackWorkspace = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagBundleTargetDiscriminatorType.SlackWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget)}");
                slackWorkspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeTagBundleTarget(
                discriminator?.Type,
                slackChannel,

                slackWorkspace
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeTagBundleTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsSlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackChannelBundleTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackChannelBundleTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackChannel(), typeInfo);
            }
            else if (value.IsSlackWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceBundleTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackWorkspace(), typeInfo);
            }
        }
    }
}