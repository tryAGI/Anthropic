#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptCachingBetaMessageStopReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.PromptCachingBetaMessageStopReason>
    {
        /// <inheritdoc />
        public override global::Anthropic.PromptCachingBetaMessageStopReason Read(
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
                        return global::Anthropic.PromptCachingBetaMessageStopReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.PromptCachingBetaMessageStopReason)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.PromptCachingBetaMessageStopReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.PromptCachingBetaMessageStopReasonExtensions.ToValueString(value));
        }
    }
}