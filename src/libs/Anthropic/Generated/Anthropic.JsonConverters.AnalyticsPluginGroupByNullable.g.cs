#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnalyticsPluginGroupByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.AnalyticsPluginGroupBy?>
    {
        /// <inheritdoc />
        public override global::Anthropic.AnalyticsPluginGroupBy? Read(
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
                        return global::Anthropic.AnalyticsPluginGroupByExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.AnalyticsPluginGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.AnalyticsPluginGroupBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.AnalyticsPluginGroupBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.AnalyticsPluginGroupByExtensions.ToValueString(value.Value));
            }
        }
    }
}
