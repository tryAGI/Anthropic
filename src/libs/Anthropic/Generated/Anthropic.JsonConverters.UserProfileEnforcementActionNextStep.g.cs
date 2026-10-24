#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserProfileEnforcementActionNextStepJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.UserProfileEnforcementActionNextStep>
    {
        /// <inheritdoc />
        public override global::Anthropic.UserProfileEnforcementActionNextStep Read(
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
                        return global::Anthropic.UserProfileEnforcementActionNextStepExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.UserProfileEnforcementActionNextStep)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.UserProfileEnforcementActionNextStep);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.UserProfileEnforcementActionNextStep value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.UserProfileEnforcementActionNextStepExtensions.ToValueString(value));
        }
    }
}
