#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeTagSettingSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeTagSettingSource>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeTagSettingSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSettingSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSettingSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSettingSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeTagSlackChannelSettingSource? slackChannel = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType.SlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackChannelSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackChannelSettingSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackChannelSettingSource)}");
                slackChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource? slackWorkspace = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType.SlackWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource)}");
                slackWorkspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource? slackParentChannel = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType.SlackParentChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource)}");
                slackParentChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagSlackDefaultSettingSource? slackDefault = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType.SlackDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackDefaultSettingSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource)}");
                slackDefault = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagDefaultSettingSource? @default = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType.Default)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagDefaultSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagDefaultSettingSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagDefaultSettingSource)}");
                @default = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource? slackGridChannel = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeTagSettingSourceDiscriminatorType.SlackGridChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource)}");
                slackGridChannel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeTagSettingSource(
                discriminator?.Type,
                slackChannel,

                slackWorkspace,

                slackParentChannel,

                slackDefault,

                @default,

                slackGridChannel
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeTagSettingSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsSlackChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackChannelSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackChannelSettingSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackChannelSettingSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackChannel(), typeInfo);
            }
            else if (value.IsSlackWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackWorkspaceSettingSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackWorkspace(), typeInfo);
            }
            else if (value.IsSlackParentChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackParentChannelSettingSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackParentChannel(), typeInfo);
            }
            else if (value.IsSlackDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackDefaultSettingSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackDefaultSettingSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackDefault(), typeInfo);
            }
            else if (value.IsDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagDefaultSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagDefaultSettingSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagDefaultSettingSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDefault(), typeInfo);
            }
            else if (value.IsSlackGridChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeTagSlackGridChannelSettingSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSlackGridChannel(), typeInfo);
            }
        }
    }
}