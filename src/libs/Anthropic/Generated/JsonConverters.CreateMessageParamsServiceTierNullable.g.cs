#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateMessageParamsServiceTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CreateMessageParamsServiceTier?>
    {
        /// <inheritdoc />
        public override global::Anthropic.CreateMessageParamsServiceTier? Read(
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
                        return global::Anthropic.CreateMessageParamsServiceTierExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.CreateMessageParamsServiceTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.CreateMessageParamsServiceTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CreateMessageParamsServiceTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.CreateMessageParamsServiceTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
