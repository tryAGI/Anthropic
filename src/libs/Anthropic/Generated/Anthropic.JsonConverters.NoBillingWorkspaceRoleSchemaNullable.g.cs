#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class NoBillingWorkspaceRoleSchemaNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.NoBillingWorkspaceRoleSchema?>
    {
        /// <inheritdoc />
        public override global::Anthropic.NoBillingWorkspaceRoleSchema? Read(
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
                        return global::Anthropic.NoBillingWorkspaceRoleSchemaExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.NoBillingWorkspaceRoleSchema)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.NoBillingWorkspaceRoleSchema?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.NoBillingWorkspaceRoleSchema? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.NoBillingWorkspaceRoleSchemaExtensions.ToValueString(value.Value));
            }
        }
    }
}
