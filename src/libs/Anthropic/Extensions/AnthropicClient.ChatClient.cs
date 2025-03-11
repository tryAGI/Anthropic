using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

// ReSharper disable ConvertTypeCheckPatternToNullCheck
// ReSharper disable once CheckNamespace

namespace Anthropic;

public partial class AnthropicClient : IChatClient
{
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    object? IChatClient.GetService(Type? serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? (_metadata ??= new(nameof(AnthropicClient), this.BaseUri)) :
            serviceType?.IsInstanceOfType(this) is true ? this :
            null;
    }

    async Task<ChatResponse> IChatClient.GetResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options, CancellationToken cancellationToken)
    {
        CreateMessageParams request = CreateRequest(messages, options);

        var response = await this.Messages.MessagesPostAsync(request, anthropicVersion: "2023-06-01", cancellationToken).ConfigureAwait(false);

        ChatMessage responseMessage = new()
        {
            Role = response.Role == MessageRole.Assistant ? ChatRole.Assistant : ChatRole.User,
            RawRepresentation = response,
        };

        if (response.StopSequence is not null)
        {
            (responseMessage.AdditionalProperties ??= [])[nameof(response.StopSequence)] = response.StopSequence;
        }

        // if (response.Content.Value1 is string stringContents)
        // {
        //     responseMessage.Contents.Add(new TextContent(stringContents));
        // }
        //else if (response.Content.Value2 is IList<Block> blocks)
        {
            foreach (var block in response.Content)
            {
                if (block.IsText)
                {
                    responseMessage.Contents.Add(new TextContent(block.Text!.Text) { RawRepresentation = block.Text });
                }
                // else if (block.IsImage)
                // {
                //     responseMessage.Contents.Add(new ImageContent(
                //         block.Image!.Source.Data,
                //         block.Image!.Source.MediaType switch
                //         {
                //             ImageBlockSourceMediaType.ImagePng => "image/png",
                //             ImageBlockSourceMediaType.ImageGif => "image/gif",
                //             ImageBlockSourceMediaType.ImageWebp => "image/webp",
                //             _ => "image/jpeg",
                //         })
                //     {
                //         RawRepresentation = block.Image
                //     });
                // }
                else if (block.IsToolUse)
                {
                    responseMessage.Contents.Add(new FunctionCallContent(
                        block.ToolUse!.Id,
                        block.ToolUse!.Name,
                        block.ToolUse!.Input is JsonElement e ? (IDictionary<string, object?>?)e.Deserialize(
                            JsonSerializerContext.Options.GetTypeInfo(typeof(Dictionary<string, object?>))) :
                            null));
                }
            }
        }

        ChatResponse completion = new(responseMessage)
        {
            ResponseId = response.Id,
            ModelId = response.Model,
            FinishReason = response.StopReason switch
            {
                null => null,
                MessageStopReason.EndTurn or MessageStopReason.StopSequence => ChatFinishReason.Stop,
                MessageStopReason.MaxTokens => ChatFinishReason.Length,
                MessageStopReason.ToolUse => ChatFinishReason.ToolCalls,
                _ => new ChatFinishReason(response.StopReason?.ToString() ?? "Unknown"),
            },
        };

        if (response.Usage is Usage u)
        {
            completion.Usage = new()
            {
                InputTokenCount = u.InputTokens,
                OutputTokenCount = u.OutputTokens,
                TotalTokenCount = u.InputTokens + u.OutputTokens,
            };

            // if (u.CacheCreationInputTokens is not null)
            // {
            //     (completion.Usage.AdditionalProperties ??= [])[nameof(u.CacheCreationInputTokens)] = u.CacheCreationInputTokens;
            // }
            //
            // if (u.CacheReadInputTokens is not null)
            // {
            //     (completion.Usage.AdditionalProperties ??= [])[nameof(u.CacheReadInputTokens)] = u.CacheReadInputTokens;
            // }
        }

        return completion;
    }

    async IAsyncEnumerable<ChatResponseUpdate> IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        CreateMessageParams request = CreateRequest(messages, options);
        
        IAsyncEnumerable<MessageStreamEvent> enumerable =
            CreateMessageAsStreamAsync(request, anthropicVersion: "2023-06-01", cancellationToken);

        await foreach (var response in enumerable.ConfigureAwait(false))
        {
            var chatResponseUpdate = new ChatResponseUpdate();
            if (response.IsContentBlockDelta)
            {
                var delta = response.ContentBlockDelta!.Delta;
                if (delta.IsTextDelta)
                {
                    chatResponseUpdate.Contents.Add(new TextContent(delta.TextDelta!.Text) { RawRepresentation = delta.TextDelta!.Text });
                }
            }

            yield return chatResponseUpdate;
            // yield return new ChatResponseUpdate
            // {
            //     //AdditionalProperties = response.AdditionalProperties,
            //     //AuthorName = choice.AuthorName,
            //     ChatThreadId = response.ChatThreadId,
            //     ChoiceIndex = i,
            //     ResponseId = response.ResponseId,
            //     Contents = choice.Contents,
            //     CreatedAt = response.CreatedAt,
            //     FinishReason = response.FinishReason,
            //     ModelId = response.ModelId,
            //     RawRepresentation = choice.RawRepresentation,
            //     Role = choice.Role,
            // };
        }
    }

    private static CreateMessageParams CreateRequest(IEnumerable<ChatMessage> chatMessages, ChatOptions? options)
    {
        string? systemMessage = null;

        List<InputMessage> messages = [];
        foreach (var chatMessage in chatMessages)
        {
            if (chatMessage.Role == ChatRole.System)
            {
                systemMessage = string.Concat(chatMessage.Contents.OfType<TextContent>());
                if (string.IsNullOrEmpty(systemMessage))
                {
                    systemMessage = null;
                }
                continue;
            }

            List<InputContentBlock> blocks = [];
            foreach (var content in chatMessage.Contents)
            {
                switch (content)
                {
                    case TextContent tc:
                        blocks.Add(new InputContentBlock(new RequestTextBlock { Text = tc.Text }));
                        break;

                    case DataContent ic when ic.HasTopLevelMediaType("image"):
                        blocks.Add(new InputContentBlock(new RequestImageBlock
                        {
                            Source = new Base64ImageSource
                            {
                                MediaType = ic.MediaType switch
                                {
                                    "image/png" => Base64ImageSourceMediaType.ImagePng,
                                    "image/gif" => Base64ImageSourceMediaType.ImageGif,
                                    "image/webp" => Base64ImageSourceMediaType.ImageWebp,
                                    _ => Base64ImageSourceMediaType.ImageJpeg,
                                },
                                Data = ic.Data.ToArray() ?? [], //Convert.ToBase64String(ic.Data?.ToArray() ?? []),
                                Type = Base64ImageSourceType.Base64,
                            }
                        }));
                        break;

                    case FunctionCallContent fcc:
                        blocks.Add(new InputContentBlock(new RequestToolUseBlock
                        {
                            Id = fcc.CallId,
                            Name = fcc.Name,
                            Input = fcc.Arguments ?? new Dictionary<string, object?>(),
                        }));
                        break;

                    case FunctionResultContent frc:
                        blocks.Add(new InputContentBlock(new RequestToolResultBlock
                        {
                            ToolUseId = frc.CallId,
                            Content = frc.Result?.ToString() ?? string.Empty,
                            IsError = frc.Exception is not null ? true : null,
                        }));
                        break;
                }

                foreach (InputContentBlock block in blocks)
                {
                    messages.Add(new InputMessage
                    {
                        Role = chatMessage.Role == ChatRole.Assistant ? InputMessageRole.Assistant : InputMessageRole.User,
                        Content = new([block])
                    });
                }
            }
        }

        var request = new CreateMessageParams
        {
            MaxTokens = options?.MaxOutputTokens ?? 250,
            Messages = messages,
            Model = options?.ModelId ?? string.Empty,
            StopSequences = options?.StopSequences,
            System = systemMessage is not null ? new(systemMessage) : null,
            Temperature = options?.Temperature,
            TopP = options?.TopP,
            TopK = options?.TopK,
            ToolChoice =
                options?.Tools is not { Count: > 0 } ? null:
                options?.ToolMode is AutoChatToolMode ? new ToolChoice(new ToolChoiceAuto()) :
                options?.ToolMode is RequiredChatToolMode r
                    ? r.RequiredFunctionName is not null
                        ? new ToolChoice(new ToolChoiceTool
                        {
                            Name = r.RequiredFunctionName,
                        })
                        : new ToolChoice(new ToolChoiceAny())
                    : (ToolChoice?)null,
            Tools = options?.Tools is IList<AITool> tools ?
                tools.OfType<AIFunction>().Select(f => new OneOf<Tool, BashTool20250124, TextEditor20250124>(new Tool
                {
                    Name = f.Name,
                    Description = f.Description,
                    InputSchema = CreateSchema(f),
                })).ToList() :
                null,
        };
        return request;
    }

    private static ToolParameterJsonSchema CreateSchema(AIFunction f) =>
        JsonSerializer.Deserialize(f.JsonSchema, SourceGenerationContext.Default.ToolParameterJsonSchema) ??
        new();
}