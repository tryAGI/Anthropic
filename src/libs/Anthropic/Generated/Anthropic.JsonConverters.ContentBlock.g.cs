#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ContentBlock>
    {
        /// <inheritdoc />
        public override global::Anthropic.ContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaResponseTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseTextBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseThinkingBlock? thinking = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseThinkingBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseRedactedThinkingBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseToolUseBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseServerToolUseBlock? serverToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.ServerToolUse)
            {
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseServerToolUseBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseWebSearchToolResultBlock? webSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.WebSearchToolResult)
            {
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseWebSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseWebFetchToolResultBlock? webFetchToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.WebFetchToolResult)
            {
                webFetchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseWebFetchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseCodeExecutionToolResultBlock? codeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.CodeExecutionToolResult)
            {
                codeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.BashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseToolSearchToolResultBlock? toolSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.ToolSearchToolResult)
            {
                toolSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseToolSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseMCPToolUseBlock? mcpToolUse = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.McpToolUse)
            {
                mcpToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseMCPToolUseBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseMCPToolResultBlock? mcpToolResult = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.McpToolResult)
            {
                mcpToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseMCPToolResultBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseContainerUploadBlock? containerUpload = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.ContainerUpload)
            {
                containerUpload = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseContainerUploadBlock>(ref reader, options);
            }
            global::Anthropic.BetaResponseCompactionBlock? compaction = default;
            if (discriminator?.Type == global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType.Compaction)
            {
                compaction = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseCompactionBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.ContentBlock(
                discriminator?.Type,
                text,

                thinking,

                redactedThinking,

                toolUse,

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
            global::Anthropic.ContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.BetaResponseTextBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::Anthropic.BetaResponseThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::Anthropic.BetaResponseRedactedThinkingBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::Anthropic.BetaResponseToolUseBlock), options);
            }
            else if (value.IsServerToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeof(global::Anthropic.BetaResponseServerToolUseBlock), options);
            }
            else if (value.IsWebSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeof(global::Anthropic.BetaResponseWebSearchToolResultBlock), options);
            }
            else if (value.IsWebFetchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchToolResult, typeof(global::Anthropic.BetaResponseWebFetchToolResultBlock), options);
            }
            else if (value.IsCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionToolResult, typeof(global::Anthropic.BetaResponseCodeExecutionToolResultBlock), options);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult, typeof(global::Anthropic.BetaResponseBashCodeExecutionToolResultBlock), options);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult, typeof(global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultBlock), options);
            }
            else if (value.IsToolSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolResult, typeof(global::Anthropic.BetaResponseToolSearchToolResultBlock), options);
            }
            else if (value.IsMcpToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolUse, typeof(global::Anthropic.BetaResponseMCPToolUseBlock), options);
            }
            else if (value.IsMcpToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolResult, typeof(global::Anthropic.BetaResponseMCPToolResultBlock), options);
            }
            else if (value.IsContainerUpload)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerUpload, typeof(global::Anthropic.BetaResponseContainerUploadBlock), options);
            }
            else if (value.IsCompaction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction, typeof(global::Anthropic.BetaResponseCompactionBlock), options);
            }
        }
    }
}