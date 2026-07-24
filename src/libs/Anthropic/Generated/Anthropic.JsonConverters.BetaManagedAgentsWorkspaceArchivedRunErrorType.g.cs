#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaManagedAgentsWorkspaceArchivedRunErrorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorType>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorType Read(
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
                        return global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Anthropic.BetaManagedAgentsWorkspaceArchivedRunErrorTypeExtensions.ToValueString(value));
        }
    }
}
