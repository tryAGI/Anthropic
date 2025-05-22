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

            var
            readerCopy = reader;
            global::Anthropic.RequestServerToolUseBlock? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestServerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestServerToolUseBlock).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.RequestWebSearchToolResultBlock? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestWebSearchToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestWebSearchToolResultBlock).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Anthropic.InputContentBlock(
                value1,
                value2,
                value3,
                value4,
                value5,
                value6,
                value7,
                value8,
                value9
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestServerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestServerToolUseBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestWebSearchToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestWebSearchToolResultBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestServerToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestServerToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RequestWebSearchToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RequestWebSearchToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
        }
    }
}