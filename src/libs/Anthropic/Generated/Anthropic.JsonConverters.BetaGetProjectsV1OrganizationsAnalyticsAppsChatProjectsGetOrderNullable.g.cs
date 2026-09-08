#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? Read(
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
                        return global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaGetProjectsV1OrganizationsAnalyticsAppsChatProjectsGetOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
