#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaManagedAgentsAgentAutoEvaluatedPermissionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow? allow = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Allow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow)}");
                allow = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk? ask = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Ask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk)}");
                ask = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny? deny = default;
            if (discriminator?.Type == global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDiscriminatorType.Deny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny)}");
                deny = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission(
                discriminator?.Type,
                allow,

                ask,

                deny
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAllow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAllow).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Allow!, typeInfo);
            }
            else if (value.IsAsk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionAsk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ask!, typeInfo);
            }
            else if (value.IsDeny)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermissionDeny).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deny!, typeInfo);
            }
        }
    }
}