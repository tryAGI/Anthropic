#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestRedactedThinkingBlockTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.RequestRedactedThinkingBlockType?>
    {
        /// <inheritdoc />
        public override global::Anthropic.RequestRedactedThinkingBlockType? Read(
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
                        return global::Anthropic.RequestRedactedThinkingBlockTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.RequestRedactedThinkingBlockType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.RequestRedactedThinkingBlockType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.RequestRedactedThinkingBlockTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
