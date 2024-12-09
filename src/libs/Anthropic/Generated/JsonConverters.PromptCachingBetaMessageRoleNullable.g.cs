#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptCachingBetaMessageRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.PromptCachingBetaMessageRole?>
    {
        /// <inheritdoc />
        public override global::Anthropic.PromptCachingBetaMessageRole? Read(
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
                        return global::Anthropic.PromptCachingBetaMessageRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.PromptCachingBetaMessageRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.PromptCachingBetaMessageRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.PromptCachingBetaMessageRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
