#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaGetUsersV1OrganizationsAnalyticsUsersGetOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder? Read(
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
                        return global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaGetUsersV1OrganizationsAnalyticsUsersGetOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
