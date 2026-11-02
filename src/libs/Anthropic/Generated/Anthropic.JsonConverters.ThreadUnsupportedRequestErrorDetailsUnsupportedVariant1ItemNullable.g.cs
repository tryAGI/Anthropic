#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1ItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item?>
    {
        /// <inheritdoc />
        public override global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? Read(
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
                        return global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1ItemExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.ThreadUnsupportedRequestErrorDetailsUnsupportedVariant1ItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
