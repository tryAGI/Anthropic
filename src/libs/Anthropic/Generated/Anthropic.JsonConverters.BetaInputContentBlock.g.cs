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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaInputContentBlockDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaRequestTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestTextBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestImageBlock? image = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestImageBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestDocumentBlock? document = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestDocumentBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestSearchResultBlock? searchResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.SearchResult)
            {
                searchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestSearchResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestThinkingBlock? thinking = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestThinkingBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestRedactedThinkingBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestToolUseBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestToolResultBlock? toolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.ToolResult)
            {
                toolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestServerToolUseBlock? serverToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.ServerToolUse)
            {
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestServerToolUseBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestWebSearchToolResultBlock? webSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.WebSearchToolResult)
            {
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestWebSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestWebFetchToolResultBlock? webFetchToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.WebFetchToolResult)
            {
                webFetchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestWebFetchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestCodeExecutionToolResultBlock? codeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.CodeExecutionToolResult)
            {
                codeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.BashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestToolSearchToolResultBlock? toolSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.ToolSearchToolResult)
            {
                toolSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestToolSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestMCPToolUseBlock? mcpToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.McpToolUse)
            {
                mcpToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestMCPToolUseBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestMCPToolResultBlock? mcpToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.McpToolResult)
            {
                mcpToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestMCPToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestContainerUploadBlock? containerUpload = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.ContainerUpload)
            {
                containerUpload = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestContainerUploadBlock>(ref reader, options);
            }
            global::Anthropic.BetaRequestCompactionBlock? compaction = default;
            if (discriminator?.Type == global::Anthropic.BetaInputContentBlockDiscriminatorType.Compaction)
            {
                compaction = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaRequestCompactionBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.BetaInputContentBlock(
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

                mcpToolUse,

                mcpToolResult,

                containerUpload,

                compaction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaInputContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.BetaRequestTextBlock), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Anthropic.BetaRequestImageBlock), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::Anthropic.BetaRequestDocumentBlock), options);
            }
            else if (value.IsSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResult, typeof(global::Anthropic.BetaRequestSearchResultBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::Anthropic.BetaRequestThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::Anthropic.BetaRequestRedactedThinkingBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::Anthropic.BetaRequestToolUseBlock), options);
            }
            else if (value.IsToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolResult, typeof(global::Anthropic.BetaRequestToolResultBlock), options);
            }
            else if (value.IsServerToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeof(global::Anthropic.BetaRequestServerToolUseBlock), options);
            }
            else if (value.IsWebSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock), options);
            }
            else if (value.IsWebFetchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchToolResult, typeof(global::Anthropic.BetaRequestWebFetchToolResultBlock), options);
            }
            else if (value.IsCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionToolResult, typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock), options);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult, typeof(global::Anthropic.BetaRequestBashCodeExecutionToolResultBlock), options);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult, typeof(global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultBlock), options);
            }
            else if (value.IsToolSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolResult, typeof(global::Anthropic.BetaRequestToolSearchToolResultBlock), options);
            }
            else if (value.IsMcpToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolUse, typeof(global::Anthropic.BetaRequestMCPToolUseBlock), options);
            }
            else if (value.IsMcpToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolResult, typeof(global::Anthropic.BetaRequestMCPToolResultBlock), options);
            }
            else if (value.IsContainerUpload)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerUpload, typeof(global::Anthropic.BetaRequestContainerUploadBlock), options);
            }
            else if (value.IsCompaction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeof(global::Anthropic.BetaRequestCompactionBlock), options);
            }
        }
    }
}