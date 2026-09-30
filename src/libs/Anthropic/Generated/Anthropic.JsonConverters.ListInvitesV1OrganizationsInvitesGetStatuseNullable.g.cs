#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListInvitesV1OrganizationsInvitesGetStatuseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse?>
    {
        /// <inheritdoc />
        public override global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? Read(
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
                        return global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuse? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.ListInvitesV1OrganizationsInvitesGetStatuseExtensions.ToValueString(value.Value));
            }
        }
    }
}
