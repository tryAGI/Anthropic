#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent Read(
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
                        return global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEventExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEventExtensions.ToValueString(value));
        }
    }
}
