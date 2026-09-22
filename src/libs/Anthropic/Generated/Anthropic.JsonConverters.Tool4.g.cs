#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Tool4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Tool4>
    {
        /// <inheritdoc />
        public override global::Anthropic.Tool4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaResponseToolChangeToolReference? toolReference = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType.ToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolChangeToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolChangeToolReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseToolChangeToolReference)}");
                toolReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseToolChangeMCPToolReference? mcpToolReference = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType.McpToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolChangeMCPToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolChangeMCPToolReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseToolChangeMCPToolReference)}");
                mcpToolReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseToolChangeMCPToolsetReference? mcpToolsetReference = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType.McpToolsetReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolChangeMCPToolsetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolChangeMCPToolsetReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseToolChangeMCPToolsetReference)}");
                mcpToolsetReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Tool4(
                discriminator?.Type,
                toolReference,

                mcpToolReference,

                mcpToolsetReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Tool4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolChangeToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolChangeToolReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseToolChangeToolReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReference!, typeInfo);
            }
            else if (value.IsMcpToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolChangeMCPToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolChangeMCPToolReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseToolChangeMCPToolReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolReference!, typeInfo);
            }
            else if (value.IsMcpToolsetReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseToolChangeMCPToolsetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseToolChangeMCPToolsetReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseToolChangeMCPToolsetReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolsetReference!, typeInfo);
            }
        }
    }
}