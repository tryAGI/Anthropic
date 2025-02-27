#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ToolsItem>
    {
        /// <inheritdoc />
        public override global::Anthropic.ToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCountMessageTokensParamsToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCountMessageTokensParamsToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaCountMessageTokensParamsToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaTool? custom = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTool)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaComputerUseTool20241022? computer20241022 = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.Computer20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20241022> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaComputerUseTool20241022)}");
                computer20241022 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaBashTool20241022? bash20241022 = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.Bash20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20241022> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBashTool20241022)}");
                bash20241022 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTextEditor20241022? textEditor20241022 = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.TextEditor20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20241022> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTextEditor20241022)}");
                textEditor20241022 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaComputerUseTool20250124? computer20250124 = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.Computer20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20250124> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaComputerUseTool20250124)}");
                computer20250124 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaBashTool20250124? bash20250124 = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.Bash20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20250124> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaBashTool20250124)}");
                bash20250124 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaTextEditor20250124? textEditor20250124 = default;
            if (discriminator?.Type == global::Anthropic.BetaCountMessageTokensParamsToolDiscriminatorType.TextEditor20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250124> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaTextEditor20250124)}");
                textEditor20250124 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.ToolsItem(
                discriminator?.Type,
                custom,
                computer20241022,
                bash20241022,
                textEditor20241022,
                computer20250124,
                bash20250124,
                textEditor20250124
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Custom, typeInfo);
            }
            else if (value.IsComputer20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer20241022, typeInfo);
            }
            else if (value.IsBash20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash20241022, typeInfo);
            }
            else if (value.IsTextEditor20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20241022, typeInfo);
            }
            else if (value.IsComputer20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer20250124, typeInfo);
            }
            else if (value.IsBash20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash20250124, typeInfo);
            }
            else if (value.IsTextEditor20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20250124, typeInfo);
            }
        }
    }
}