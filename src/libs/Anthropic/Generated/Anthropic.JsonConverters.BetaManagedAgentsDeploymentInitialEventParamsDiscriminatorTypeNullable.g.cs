#nullable enable

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Read(
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
                        return global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
