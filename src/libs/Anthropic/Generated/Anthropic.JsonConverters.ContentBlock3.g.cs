#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ContentBlock3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ContentBlock3>
    {
        /// <inheritdoc />
        public override global::Anthropic.ContentBlock3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ResponseTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.ToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseToolUseBlock)}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseServerToolUseBlock? serverToolUse = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.ServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseServerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseServerToolUseBlock)}");
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseWebSearchToolResultBlock? webSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.WebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseWebSearchToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseWebSearchToolResultBlock)}");
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseThinkingBlock? thinking = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseThinkingBlock)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.RedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseRedactedThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseRedactedThinkingBlock)}");
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.ContentBlock3(
                discriminator?.Type,
                text,
                toolUse,
                serverToolUse,
                webSearchToolResult,
                thinking,
                redactedThinking
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ContentBlock3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeInfo);
            }
            else if (value.IsServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseServerToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseServerToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeInfo);
            }
            else if (value.IsWebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseWebSearchToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseWebSearchToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeInfo);
            }
            else if (value.IsRedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseRedactedThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseRedactedThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeInfo);
            }
        }
    }
}