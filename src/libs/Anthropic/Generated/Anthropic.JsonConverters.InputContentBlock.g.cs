#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class InputContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.InputContentBlock>
    {
        /// <inheritdoc />
        public override global::Anthropic.InputContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.InputContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.InputContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.InputContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.RequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestImageBlock? image = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestImageBlock)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestDocumentBlock? document = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Document)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestDocumentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestDocumentBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestDocumentBlock)}");
                document = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestSearchResultBlock? searchResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.SearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestSearchResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestSearchResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestSearchResultBlock)}");
                searchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestThinkingBlock? thinking = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestThinkingBlock)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.RedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestRedactedThinkingBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestRedactedThinkingBlock)}");
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestToolUseBlock)}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestToolResultBlock)}");
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestServerToolUseBlock? serverToolUse = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestServerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestServerToolUseBlock)}");
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RequestWebSearchToolResultBlock? webSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.WebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestWebSearchToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RequestWebSearchToolResultBlock)}");
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.InputContentBlock(
                discriminator?.Type,
                text,
                image,
                document,
                searchResult,
                thinking,
                redactedThinking,
                toolUse,
                toolResult,
                serverToolUse,
                webSearchToolResult
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.InputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestImageBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestImageBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestDocumentBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestDocumentBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestDocumentBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
            else if (value.IsSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestSearchResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestSearchResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestSearchResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResult, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeInfo);
            }
            else if (value.IsRedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestRedactedThinkingBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestRedactedThinkingBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestRedactedThinkingBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeInfo);
            }
            else if (value.IsToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeInfo);
            }
            else if (value.IsServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestServerToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestServerToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeInfo);
            }
            else if (value.IsWebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestWebSearchToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestWebSearchToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeInfo);
            }
        }
    }
}