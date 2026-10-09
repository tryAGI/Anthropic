#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsMultiagentWorkflowsParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams? enabled = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType.Enabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams)}");
                enabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams? disabled = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParamsDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams(
                discriminator?.Type,
                enabled,

                disabled
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabledParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEnabled(), typeInfo);
            }
            else if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabledParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDisabled(), typeInfo);
            }
        }
    }
}