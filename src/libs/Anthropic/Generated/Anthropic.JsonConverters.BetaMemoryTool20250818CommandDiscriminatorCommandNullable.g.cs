#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaMemoryTool20250818CommandDiscriminatorCommandNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Read(
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
                        return global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommandExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommandExtensions.ToValueString(value.Value));
            }
        }
    }
}
