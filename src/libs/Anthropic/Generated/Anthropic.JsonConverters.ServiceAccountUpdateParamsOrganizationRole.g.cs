#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ServiceAccountUpdateParamsOrganizationRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ServiceAccountUpdateParamsOrganizationRole>
    {
        /// <inheritdoc />
        public override global::Anthropic.ServiceAccountUpdateParamsOrganizationRole Read(
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
                        return global::Anthropic.ServiceAccountUpdateParamsOrganizationRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.ServiceAccountUpdateParamsOrganizationRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.ServiceAccountUpdateParamsOrganizationRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ServiceAccountUpdateParamsOrganizationRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.ServiceAccountUpdateParamsOrganizationRoleExtensions.ToValueString(value));
        }
    }
}
