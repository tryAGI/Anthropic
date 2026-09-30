#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class AllowedInferenceGeoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.AllowedInferenceGeo>
    {
        /// <inheritdoc />
        public override global::Anthropic.AllowedInferenceGeo Read(
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
                        return global::Anthropic.AllowedInferenceGeoExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.AllowedInferenceGeo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.AllowedInferenceGeo);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.AllowedInferenceGeo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.AllowedInferenceGeoExtensions.ToValueString(value));
        }
    }
}
