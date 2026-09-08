#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType Read(
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
                        return global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.BetaGetOrgRateLimitsV1OrganizationsRateLimitsGetGroupTypeExtensions.ToValueString(value));
        }
    }
}
