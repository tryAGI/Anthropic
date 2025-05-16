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

        var response = await this.Messages.MessagesPostAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);

        ChatMessage responseMessage = new()
        {
            MessageId = response.Id,
            Role = ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (response.StopSequence is not null)
        {
            (responseMessage.AdditionalProperties ??= [])[nameof(response.StopSequence)] = response.StopSequence;
        }

        foreach (var block in response.Content)
        {
            if (block.IsText)
            {
                responseMessage.Contents.Add(new TextContent(block.Text!.Text) { RawRepresentation = block });
            }
            else if (block.IsThinking)
            {
                responseMessage.Contents.Add(new TextReasoningContent(block.Thinking!.Thinking)
                {
                    AdditionalProperties = new() { [nameof(RequestThinkingBlock.Signature)] = block.Thinking.Signature },
                    RawRepresentation = block,
                });
            }
            else if (block.IsToolUse)
            {
                responseMessage.Contents.Add(new FunctionCallContent(
                    block.ToolUse!.Id,
                    block.ToolUse!.Name,
                    block.ToolUse!.Input is JsonElement e ? (IDictionary<string, object?>?)e.Deserialize(
                        JsonSerializerContext.Options.GetTypeInfo(typeof(Dictionary<string, object?>))) :
                        null)
                {
                    RawRepresentation = block
                });
            }
        }

        ChatResponse completion = new(responseMessage)
        {
            RawRepresentation = response,
            ResponseId = response.Id,
            ModelId = response.Model,
            FinishReason = response.StopReason switch
            {
                StopReason.EndTurn or StopReason.StopSequence => ChatFinishReason.Stop,
                StopReason.MaxTokens => ChatFinishReason.Length,
                StopReason.ToolUse => ChatFinishReason.ToolCalls,
                _ => new ChatFinishReason(response.StopReason.ToString()),
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

            if (u.CacheCreationInputTokens is int cacheCreationTokens)
            {
                (completion.Usage.AdditionalCounts ??= [])[nameof(u.CacheCreationInputTokens)] = cacheCreationTokens;
            }

            if (u.CacheReadInputTokens is int cacheReadTokens)
            {
                (completion.Usage.AdditionalCounts ??= [])[nameof(u.CacheReadInputTokens)] = cacheReadTokens;
            }
        }

        return completion;
    }

    async IAsyncEnumerable<ChatResponseUpdate> IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        CreateMessageParams request = CreateRequest(messages, options);
        
        IAsyncEnumerable<MessageStreamEvent> enumerable =
            CreateMessageAsStreamAsync(request, cancellationToken: cancellationToken);

        await foreach (var response in enumerable.ConfigureAwait(false))
        {
            ChatResponseUpdate chatResponseUpdate = new();

            if (response.IsContentBlockDelta)
            {
                var delta = response.ContentBlockDelta!.Delta;
                if (delta.IsTextDelta)
                {
                    chatResponseUpdate.Contents.Add(new TextContent(delta.TextDelta!.Text) { RawRepresentation = response });
                }
            }

            yield return chatResponseUpdate;
        }
    }

    private CreateMessageParams CreateRequest(IEnumerable<ChatMessage> chatMessages, ChatOptions? options)
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

                    case TextReasoningContent trc:
                        blocks.Add(new InputContentBlock(new RequestThinkingBlock
                        {
                            Thinking = trc.Text,
                            Signature = trc.AdditionalProperties?.TryGetValue(nameof(RequestThinkingBlock.Signature), out string? sig) is true ? sig : "",
                        }));
                        break;

                    case DataContent dc when dc.HasTopLevelMediaType("image"):
                        blocks.Add(new InputContentBlock(new RequestImageBlock
                        {
                            Source = new Base64ImageSource
                            {
                                MediaType = dc.MediaType switch
                                {
                                    "image/png" => Base64ImageSourceMediaType.ImagePng,
                                    "image/gif" => Base64ImageSourceMediaType.ImageGif,
                                    "image/webp" => Base64ImageSourceMediaType.ImageWebp,
                                    _ => Base64ImageSourceMediaType.ImageJpeg,
                                },
                                Data = dc.Data.ToArray() ?? [],
                                Type = Base64ImageSourceType.Base64,
                            },
                        }));
                        break;

                    case DataContent dc when dc.MediaType.Equals("application/pdf", StringComparison.OrdinalIgnoreCase):
                        blocks.Add(new InputContentBlock(new RequestDocumentBlock
                        {
                            Source = new Base64PDFSource
                            {
                                MediaType = Base64PDFSourceMediaType.ApplicationPdf,
                                Data = dc.Data.ToArray() ?? [],
                            },
                        }));
                        break;

                    case UriContent uc when uc.HasTopLevelMediaType("image"):
                        blocks.Add(new InputContentBlock(new RequestImageBlock
                        {
                            Source = new URLImageSource
                            {
                                Url = uc.Uri.ToString(),
                            },
                        }));
                        break;

                    case UriContent uc when uc.MediaType.Equals("application/pdf", StringComparison.OrdinalIgnoreCase):
                        blocks.Add(new InputContentBlock(new RequestDocumentBlock
                        {
                            Source = new URLPDFSource
                            {
                                Url = uc.Uri.ToString(),
                            },
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

        CreateMessageParams? request = options?.RawRepresentationFactory?.Invoke(this) as CreateMessageParams;
        if (request is not null)
        {
            request.Model = options?.ModelId ?? string.Empty;
            if (request.Messages is null)
            {
                request.Messages = messages;
            }
            else
            {
                foreach (var message in messages)
                {
                    request.Messages.Add(message);
                }
            }
        }
        else
        {
            request = new()
            {
                Model = options?.ModelId ?? string.Empty,
                MaxTokens = options?.MaxOutputTokens ?? 250,
                Messages = messages,
            };
        }

        request.StopSequences ??= options?.StopSequences;
        if (systemMessage is not null)
        {
            request.System ??= new(systemMessage);
        }
        request.Temperature ??= options?.Temperature;
        request.TopP ??= options?.TopP;
        request.TopK ??= options?.TopK;

        request.ToolChoice ??=
            options?.Tools is not { Count: > 0 } ? null :
            options?.ToolMode is AutoChatToolMode ? new ToolChoice(new ToolChoiceAuto()) :
            options?.ToolMode is RequiredChatToolMode r
                ? r.RequiredFunctionName is not null
                    ? new ToolChoice(new ToolChoiceTool
                    {
                        Name = r.RequiredFunctionName,
                    })
                    : new ToolChoice(new ToolChoiceAny())
                : (ToolChoice?)null;

        if (options?.Tools is { Count: > 0 } aitools)
        {
            var tools = request.Tools ?? [];
            request.Tools = tools;
            
            foreach (var tool in aitools)
            {
                switch (tool)
                {
                    case AIFunction f:
                        tools.Add(new Tool
                        {
                            Name = f.Name,
                            Description = f.Description,
                            InputSchema = CreateSchema(f),
                        });
                        break;

                    case HostedWebSearchTool ws:
                        tools.Add(new WebSearchTool20250305());
                        break;
                }
            }
        }

        return request;
    }

    private static ToolParameterJsonSchema CreateSchema(AIFunction f) =>
        JsonSerializer.Deserialize(f.JsonSchema, SourceGenerationContext.Default.ToolParameterJsonSchema) ??
        new();
}