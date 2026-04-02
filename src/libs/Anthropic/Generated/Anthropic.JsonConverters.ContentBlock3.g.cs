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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ContentBlockDiscriminator>(ref readerCopy, options);

            global::Anthropic.ResponseTextBlock? text = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseTextBlock>(ref reader, options);
            }
            global::Anthropic.ResponseThinkingBlock? thinking = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseThinkingBlock>(ref reader, options);
            }
            global::Anthropic.ResponseRedactedThinkingBlock? redactedThinking = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.RedactedThinking)
            {
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseRedactedThinkingBlock>(ref reader, options);
            }
            global::Anthropic.ResponseToolUseBlock? toolUse = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.ToolUse)
            {
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseToolUseBlock>(ref reader, options);
            }
            global::Anthropic.ResponseServerToolUseBlock? serverToolUse = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.ServerToolUse)
            {
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseServerToolUseBlock>(ref reader, options);
            }
            global::Anthropic.ResponseWebSearchToolResultBlock? webSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.WebSearchToolResult)
            {
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseWebSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.ResponseWebFetchToolResultBlock? webFetchToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.WebFetchToolResult)
            {
                webFetchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseWebFetchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.ResponseCodeExecutionToolResultBlock? codeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.CodeExecutionToolResult)
            {
                codeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.ResponseBashCodeExecutionToolResultBlock? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.BashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseBashCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock>(ref reader, options);
            }
            global::Anthropic.ResponseToolSearchToolResultBlock? toolSearchToolResult = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.ToolSearchToolResult)
            {
                toolSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseToolSearchToolResultBlock>(ref reader, options);
            }
            global::Anthropic.ResponseContainerUploadBlock? containerUpload = default;
            if (discriminator?.Type == global::Anthropic.ContentBlockDiscriminatorType.ContainerUpload)
            {
                containerUpload = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.ResponseContainerUploadBlock>(ref reader, options);
            }

            var __value = new global::Anthropic.ContentBlock3(
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

                containerUpload
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ContentBlock3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Anthropic.ResponseTextBlock), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::Anthropic.ResponseThinkingBlock), options);
            }
            else if (value.IsRedactedThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking, typeof(global::Anthropic.ResponseRedactedThinkingBlock), options);
            }
            else if (value.IsToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse, typeof(global::Anthropic.ResponseToolUseBlock), options);
            }
            else if (value.IsServerToolUse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse, typeof(global::Anthropic.ResponseServerToolUseBlock), options);
            }
            else if (value.IsWebSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult, typeof(global::Anthropic.ResponseWebSearchToolResultBlock), options);
            }
            else if (value.IsWebFetchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchToolResult, typeof(global::Anthropic.ResponseWebFetchToolResultBlock), options);
            }
            else if (value.IsCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionToolResult, typeof(global::Anthropic.ResponseCodeExecutionToolResultBlock), options);
            }
            else if (value.IsBashCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult, typeof(global::Anthropic.ResponseBashCodeExecutionToolResultBlock), options);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult, typeof(global::Anthropic.ResponseTextEditorCodeExecutionToolResultBlock), options);
            }
            else if (value.IsToolSearchToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolResult, typeof(global::Anthropic.ResponseToolSearchToolResultBlock), options);
            }
            else if (value.IsContainerUpload)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerUpload, typeof(global::Anthropic.ResponseContainerUploadBlock), options);
            }
        }
    }
}