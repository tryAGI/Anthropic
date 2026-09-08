#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaApproveSpendLimitIncreaseRequestParamsPeriodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod Read(
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
                        return global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriodExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriodExtensions.ToValueString(value));
        }
    }
}
