#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsDeploymentInitialEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsDeploymentInitialEvent>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsDeploymentInitialEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? userMessage = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? userDefineOutcome = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType.UserDefineOutcome)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent)}");
                userDefineOutcome = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? systemMessage = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsDeploymentInitialEvent(
                discriminator?.Type,
                userMessage,

                userDefineOutcome,

                systemMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsDeploymentInitialEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage!, typeInfo);
            }
            else if (value.IsUserDefineOutcome)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserDefineOutcome!, typeInfo);
            }
            else if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage!, typeInfo);
            }
        }
    }
}