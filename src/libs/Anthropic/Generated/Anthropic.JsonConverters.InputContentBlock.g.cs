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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.InputContentBlockDiscriminator>(ref readerCopy, options);

            global::Anthropic.RequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestTextBlock>(ref reader, options);
            }
            global::Anthropic.RequestImageBlock? image = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestImageBlock>(ref reader, options);
            }
            global::Anthropic.RequestDocumentBlock? document = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestDocumentBlock>(ref reader, options);
            }
            global::Anthropic.RequestSearchResultBlock? searchResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.SearchResult)
            {
                searchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestSearchResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestThinkingBlock? thinking = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestThinkingBlock>(ref reader, options);
            }
            global::Anthropic.RequestRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestRedactedThinkingBlock>(ref reader, options);
            }
            global::Anthropic.RequestToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestToolUseBlock>(ref reader, options);
            }
            global::Anthropic.RequestToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ToolResult)
            {
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestServerToolUseBlock? serverToolUse = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ServerToolUse)
            {
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestServerToolUseBlock>(ref reader, options);
            }
            global::Anthropic.RequestWebSearchToolResultBlock? webSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.WebSearchToolResult)
            {
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestWebSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestWebFetchToolResultBlock? webFetchToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.WebFetchToolResult)
            {
                webFetchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestWebFetchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestCodeExecutionToolResultBlock? codeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.CodeExecutionToolResult)
            {
                codeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.BashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestBashCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestToolSearchToolResultBlock? toolSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ToolSearchToolResult)
            {
                toolSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestToolSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.RequestContainerUploadBlock? containerUpload = default;
            if (discriminator?.Type == global::Anthropic.InputContentBlockDiscriminatorType.ContainerUpload)
            {
                containerUpload = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.RequestContainerUploadBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.InputContentBlock(
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

                webSearchToolResult,

                webFetchToolResult,

                codeExecutionToolResult,

                bashCodeExecutionToolResult,

                textEditorCodeExecutionToolResult,

                toolSearchToolResult,

                containerUpload
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.InputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.RequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Anthropic.RequestImageBlock), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::Anthropic.RequestDocumentBlock), options);
            }
            else if (value.IsSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResult, typeof(global::Anthropic.RequestSearchResultBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::Anthropic.RequestThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::Anthropic.RequestRedactedThinkingBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::Anthropic.RequestToolUseBlock), options);
            }
            else if (value.IsToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeof(global::Anthropic.RequestToolResultBlock), options);
            }
            else if (value.IsServerToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeof(global::Anthropic.RequestServerToolUseBlock), options);
            }
            else if (value.IsWebSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeof(global::Anthropic.RequestWebSearchToolResultBlock), options);
            }
            else if (value.IsWebFetchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchToolResult, typeof(global::Anthropic.RequestWebFetchToolResultBlock), options);
            }
            else if (value.IsCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionToolResult, typeof(global::Anthropic.RequestCodeExecutionToolResultBlock), options);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult, typeof(global::Anthropic.RequestBashCodeExecutionToolResultBlock), options);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult, typeof(global::Anthropic.RequestTextEditorCodeExecutionToolResultBlock), options);
            }
            else if (value.IsToolSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolResult, typeof(global::Anthropic.RequestToolSearchToolResultBlock), options);
            }
            else if (value.IsContainerUpload)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerUpload, typeof(global::Anthropic.RequestContainerUploadBlock), options);
            }
        }
    }
}