#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClaudeCodeManagedSettingsModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClaudeCodeManagedSettingsMode>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClaudeCodeManagedSettingsMode Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode? organization = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode? rbacGroups = default;
            if (discriminator?.Type == global::Anthropic.BetaClaudeCodeManagedSettingsModeDiscriminatorType.RbacGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode)}");
                rbacGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaClaudeCodeManagedSettingsMode(
                discriminator?.Type,
                organization,

                rbacGroups
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaClaudeCodeManagedSettingsMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeManagedSettingsOrganizationMode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
            else if (value.IsRbacGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaClaudeCodeManagedSettingsRbacGroupsMode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRbacGroups(), typeInfo);
            }
        }
    }
}