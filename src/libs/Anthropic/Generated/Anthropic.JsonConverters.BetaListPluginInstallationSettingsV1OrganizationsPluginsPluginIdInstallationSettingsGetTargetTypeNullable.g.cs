#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
