#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsMultiagentInlineAgentsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsMultiagentInlineAgents>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsMultiagentInlineAgents Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? enabled = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType.Enabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled)}");
                enabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? disabled = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsMultiagentInlineAgents(
                discriminator?.Type,
                enabled,

                disabled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEnabled(), typeInfo);
            }
            else if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDisabled(), typeInfo);
            }
        }
    }
}