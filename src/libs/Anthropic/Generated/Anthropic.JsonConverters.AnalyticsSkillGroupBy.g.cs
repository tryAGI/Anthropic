#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnalyticsSkillGroupByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.AnalyticsSkillGroupBy>
    {
        /// <inheritdoc />
        public override global::Anthropic.AnalyticsSkillGroupBy Read(
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
                        return global::Anthropic.AnalyticsSkillGroupByExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.AnalyticsSkillGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.AnalyticsSkillGroupBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.AnalyticsSkillGroupBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.AnalyticsSkillGroupByExtensions.ToValueString(value));
        }
    }
}
