#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlainTextSourceMediaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.PlainTextSourceMediaType>
    {
        /// <inheritdoc />
        public override global::Anthropic.PlainTextSourceMediaType Read(
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
                        return global::Anthropic.PlainTextSourceMediaTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.PlainTextSourceMediaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.PlainTextSourceMediaType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.PlainTextSourceMediaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.PlainTextSourceMediaTypeExtensions.ToValueString(value));
        }
    }
}
