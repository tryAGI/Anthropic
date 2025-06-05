#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseWebSearchResultBlockTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ResponseWebSearchResultBlockType>
    {
        /// <inheritdoc />
        public override global::Anthropic.ResponseWebSearchResultBlockType Read(
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
                        return global::Anthropic.ResponseWebSearchResultBlockTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.ResponseWebSearchResultBlockType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.ResponseWebSearchResultBlockType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ResponseWebSearchResultBlockType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.ResponseWebSearchResultBlockTypeExtensions.ToValueString(value));
        }
    }
}
