#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolChoiceNoneTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ToolChoiceNoneType>
    {
        /// <inheritdoc />
        public override global::Anthropic.ToolChoiceNoneType Read(
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
                        return global::Anthropic.ToolChoiceNoneTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.ToolChoiceNoneType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.ToolChoiceNoneType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ToolChoiceNoneType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.ToolChoiceNoneTypeExtensions.ToValueString(value));
        }
    }
}
