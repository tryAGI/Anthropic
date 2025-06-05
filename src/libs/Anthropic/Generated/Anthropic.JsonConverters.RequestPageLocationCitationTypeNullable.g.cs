#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestPageLocationCitationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.RequestPageLocationCitationType?>
    {
        /// <inheritdoc />
        public override global::Anthropic.RequestPageLocationCitationType? Read(
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
                        return global::Anthropic.RequestPageLocationCitationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.RequestPageLocationCitationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.RequestPageLocationCitationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.RequestPageLocationCitationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.RequestPageLocationCitationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
