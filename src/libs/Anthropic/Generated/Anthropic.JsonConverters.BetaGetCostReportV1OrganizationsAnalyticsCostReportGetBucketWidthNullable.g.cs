#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidthNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? Read(
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
                        return global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidthExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidth? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaGetCostReportV1OrganizationsAnalyticsCostReportGetBucketWidthExtensions.ToValueString(value.Value));
            }
        }
    }
}
