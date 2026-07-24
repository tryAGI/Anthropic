#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Tool>
    {
        /// <inheritdoc />
        public override global::Anthropic.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaToolChangeToolReference? toolReference = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType.ToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolChangeToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolChangeToolReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaToolChangeToolReference)}");
                toolReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaToolChangeMCPToolReference? mcpToolReference = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType.McpToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolChangeMCPToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolChangeMCPToolReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaToolChangeMCPToolReference)}");
                mcpToolReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaToolChangeMCPToolsetReference? mcpToolsetReference = default;
            if (discriminator?.Type == global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType.McpToolsetReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolChangeMCPToolsetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolChangeMCPToolsetReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaToolChangeMCPToolsetReference)}");
                mcpToolsetReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Tool(
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
            global::Anthropic.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolChangeToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolChangeToolReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolChangeToolReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReference!, typeInfo);
            }
            else if (value.IsMcpToolReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolChangeMCPToolReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolChangeMCPToolReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolChangeMCPToolReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolReference!, typeInfo);
            }
            else if (value.IsMcpToolsetReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolChangeMCPToolsetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolChangeMCPToolsetReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolChangeMCPToolsetReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolsetReference!, typeInfo);
            }
        }
    }
}