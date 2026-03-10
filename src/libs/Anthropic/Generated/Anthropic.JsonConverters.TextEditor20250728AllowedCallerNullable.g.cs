#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEditor20250728AllowedCallerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.TextEditor20250728AllowedCaller?>
    {
        /// <inheritdoc />
        public override global::Anthropic.TextEditor20250728AllowedCaller? Read(
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
                        return global::Anthropic.TextEditor20250728AllowedCallerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.TextEditor20250728AllowedCaller)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.TextEditor20250728AllowedCaller?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.TextEditor20250728AllowedCaller? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.TextEditor20250728AllowedCallerExtensions.ToValueString(value.Value));
            }
        }
    }
}
