#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListApiKeysV1OrganizationsApiKeysGetStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus>
    {
        /// <inheritdoc />
        public override global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus Read(
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
                        return global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.ListApiKeysV1OrganizationsApiKeysGetStatusExtensions.ToValueString(value));
        }
    }
}
