#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteMessageBatchResponseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.DeleteMessageBatchResponseType>
    {
        /// <inheritdoc />
        public override global::Anthropic.DeleteMessageBatchResponseType Read(
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
                        return global::Anthropic.DeleteMessageBatchResponseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.DeleteMessageBatchResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.DeleteMessageBatchResponseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.DeleteMessageBatchResponseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.DeleteMessageBatchResponseTypeExtensions.ToValueString(value));
        }
    }
}
