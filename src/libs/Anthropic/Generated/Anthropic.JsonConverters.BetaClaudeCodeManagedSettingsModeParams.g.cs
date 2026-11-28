#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeCodeManagedSettingsModeParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeCodeManagedSettingsModeParams>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeCodeManagedSettingsModeParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams? organization = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams? rbacGroups = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType.RbacGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams)}");
                rbacGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeCodeManagedSettingsModeParams(
                discriminator?.Type,
                organization,

                rbacGroups
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeCodeManagedSettingsModeParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationModeParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
            else if (value.IsRbacGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsModeParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRbacGroups(), typeInfo);
            }
        }
    }
}