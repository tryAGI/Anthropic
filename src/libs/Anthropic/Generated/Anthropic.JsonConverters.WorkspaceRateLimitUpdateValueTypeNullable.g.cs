#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkspaceRateLimitUpdateValueTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.WorkspaceRateLimitUpdateValueType?>
    {
        /// <inheritdoc />
        public override global::Anthropic.WorkspaceRateLimitUpdateValueType? Read(
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
                        return global::Anthropic.WorkspaceRateLimitUpdateValueTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.WorkspaceRateLimitUpdateValueType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.WorkspaceRateLimitUpdateValueType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.WorkspaceRateLimitUpdateValueType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.WorkspaceRateLimitUpdateValueTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
