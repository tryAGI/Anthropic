#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaRequestCodeExecutionToolResultBlockTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaRequestCodeExecutionToolResultBlockType?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaRequestCodeExecutionToolResultBlockType? Read(
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
                        return global::Anthropic.BetaRequestCodeExecutionToolResultBlockTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaRequestCodeExecutionToolResultBlockType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaRequestCodeExecutionToolResultBlockType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaRequestCodeExecutionToolResultBlockType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaRequestCodeExecutionToolResultBlockTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
