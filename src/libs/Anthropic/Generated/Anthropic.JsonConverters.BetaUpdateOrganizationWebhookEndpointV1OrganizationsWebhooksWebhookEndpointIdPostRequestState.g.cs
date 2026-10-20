#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState Read(
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
                        return global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestStateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestStateExtensions.ToValueString(value));
        }
    }
}
