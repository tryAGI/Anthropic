#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebSearchTool20260209AllowedCallerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.WebSearchTool20260209AllowedCaller?>
    {
        /// <inheritdoc />
        public override global::Anthropic.WebSearchTool20260209AllowedCaller? Read(
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
                        return global::Anthropic.WebSearchTool20260209AllowedCallerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.WebSearchTool20260209AllowedCaller)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.WebSearchTool20260209AllowedCaller?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.WebSearchTool20260209AllowedCaller? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.WebSearchTool20260209AllowedCallerExtensions.ToValueString(value.Value));
            }
        }
    }
}
