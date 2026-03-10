#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeExecutionTool20250825AllowedCallerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.CodeExecutionTool20250825AllowedCaller>
    {
        /// <inheritdoc />
        public override global::Anthropic.CodeExecutionTool20250825AllowedCaller Read(
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
                        return global::Anthropic.CodeExecutionTool20250825AllowedCallerExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.CodeExecutionTool20250825AllowedCaller)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.CodeExecutionTool20250825AllowedCaller);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.CodeExecutionTool20250825AllowedCaller value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.CodeExecutionTool20250825AllowedCallerExtensions.ToValueString(value));
        }
    }
}
