#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageBatchTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.MessageBatchType>
    {
        /// <inheritdoc />
        public override global::Anthropic.MessageBatchType Read(
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
                        return global::Anthropic.MessageBatchTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.MessageBatchType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.MessageBatchType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.MessageBatchType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.MessageBatchTypeExtensions.ToValueString(value));
        }
    }
}
