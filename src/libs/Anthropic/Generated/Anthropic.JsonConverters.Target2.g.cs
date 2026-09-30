#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Target2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Target2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Target2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaPluginTargetOrganization? organization = default;
            if (discriminator?.Type == global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginTargetOrganization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginTargetOrganization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaPluginTargetOrganization)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaPluginTargetRbacGroup? rbacGroup = default;
            if (discriminator?.Type == global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType.RbacGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginTargetRbacGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginTargetRbacGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaPluginTargetRbacGroup)}");
                rbacGroup = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaPluginTargetOrganizationMember? organizationMember = default;
            if (discriminator?.Type == global::Anthropic.BetaPluginInstallationSettingDeletedTargetDiscriminatorType.OrganizationMember)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginTargetOrganizationMember), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginTargetOrganizationMember> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaPluginTargetOrganizationMember)}");
                organizationMember = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Target2(
                discriminator?.Type,
                organization,

                rbacGroup,

                organizationMember
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Target2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginTargetOrganization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginTargetOrganization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaPluginTargetOrganization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
            else if (value.IsRbacGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginTargetRbacGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginTargetRbacGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaPluginTargetRbacGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRbacGroup(), typeInfo);
            }
            else if (value.IsOrganizationMember)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaPluginTargetOrganizationMember), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaPluginTargetOrganizationMember?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaPluginTargetOrganizationMember).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganizationMember(), typeInfo);
            }
        }
    }
}