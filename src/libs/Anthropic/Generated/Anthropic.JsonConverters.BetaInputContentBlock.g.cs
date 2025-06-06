#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaInputContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaInputContentBlock>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaInputContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Anthropic.BetaRequestServerToolUseBlock? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestServerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestServerToolUseBlock).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.BetaRequestWebSearchToolResultBlock? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestWebSearchToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.BetaRequestCodeExecutionToolResultBlock? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestCodeExecutionToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.BetaRequestMCPToolUseBlock? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestMCPToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestMCPToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestMCPToolUseBlock).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.BetaRequestMCPToolResultBlock? value5 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestMCPToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestMCPToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestMCPToolResultBlock).Name}");
                value5 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>? value6 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>).Name}");
                value6 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>? value7 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>).Name}");
                value7 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>? value8 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>).Name}");
                value8 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>? value9 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>).Name}");
                value9 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>? value10 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>).Name}");
                value10 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>? value11 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>).Name}");
                value11 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>? value12 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>).Name}");
                value12 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Anthropic.BetaRequestContainerUploadBlock? value13 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestContainerUploadBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestContainerUploadBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestContainerUploadBlock).Name}");
                value13 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Anthropic.BetaInputContentBlock(
                value1,
                value2,
                value3,
                value4,
                value5,
                value6,
                value7,
                value8,
                value9,
                value10,
                value11,
                value12,
                value13
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestServerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestServerToolUseBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestWebSearchToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestCodeExecutionToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestMCPToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestMCPToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestMCPToolUseBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value5 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestMCPToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestMCPToolResultBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestMCPToolResultBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value6 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value7 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value8 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value9 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value10 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value11 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value12 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value13 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestContainerUploadBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestContainerUploadBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestContainerUploadBlock).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaInputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestServerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestServerToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestServerToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestWebSearchToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestMCPToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestMCPToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestMCPToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestMCPToolResultBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestMCPToolResultBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestMCPToolResultBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRequestContainerUploadBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRequestContainerUploadBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRequestContainerUploadBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }
        }
    }
}