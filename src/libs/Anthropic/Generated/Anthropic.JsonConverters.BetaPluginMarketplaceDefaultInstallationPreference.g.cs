#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaPluginMarketplaceDefaultInstallationPreferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference Read(
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
                        return global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreferenceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreference value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.BetaPluginMarketplaceDefaultInstallationPreferenceExtensions.ToValueString(value));
        }
    }
}
