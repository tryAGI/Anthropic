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

        var response = await MessagesPostAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);

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
                        (JsonSerializerContextProvider?.Value ?? ChatClientJsonSerializerContext.Default).Options.GetTypeInfo(typeof(Dictionary<string, object?>))) :
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
            FinishReason = ToFinishReason(response.StopReason),
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

        string? responseId = null;
        string? modelId = null;
        var tools = new Dictionary<int, (ResponseToolUseBlock Tool, System.Text.StringBuilder Json)>();
        var usage = new StreamingUsage();

        await foreach (var response in enumerable.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ChatResponseUpdate update = new() { RawRepresentation = response, Role = ChatRole.Assistant };

            if (response.MessageStart is { } start)
            {
                responseId = start.Message.Id;
                modelId = start.Message.Model;
                var counts = start.Message.Usage;
                update.Contents.Add(usage.Update(counts.InputTokens, counts.OutputTokens,
                    counts.CacheCreationInputTokens, counts.CacheReadInputTokens));
            }
            else if (response.ContentBlockStart is { } blockStart && blockStart.ContentBlock.ToolUse is { } tool)
            {
                tools.Add(blockStart.Index, (tool, new()));
            }
            else if (response.ContentBlockDelta is { } blockDelta)
            {
                if (blockDelta.Delta.TextDelta is { } text)
                {
                    update.Contents.Add(new TextContent(text.Text) { RawRepresentation = response });
                }
                else if (blockDelta.Delta.InputJsonDelta is { } input && tools.TryGetValue(blockDelta.Index, out var pending))
                {
                    pending.Json.Append(input.PartialJson);
                }
            }
            else if (response.ContentBlockStop is { } stop && tools.Remove(stop.Index, out var pending))
            {
                // Only completed blocks may become executable function calls.
                var arguments = pending.Json.Length == 0 && pending.Tool.Input is IDictionary<string, object?> values
                    ? values
                    : (IDictionary<string, object?>?)JsonSerializer.Deserialize(
                        pending.Json.Length > 0 ? pending.Json.ToString() :
                        pending.Tool.Input is JsonElement element ? element.GetRawText() :
                        throw new JsonException("Tool input must be a JSON object."),
                        (JsonSerializerContextProvider?.Value ?? ChatClientJsonSerializerContext.Default)
                            .Options.GetTypeInfo(typeof(Dictionary<string, object?>)))
                      ?? throw new JsonException("Tool input must be a JSON object.");
                update.Contents.Add(new FunctionCallContent(pending.Tool.Id, pending.Tool.Name, arguments)
                {
                    RawRepresentation = pending.Tool,
                });
            }
            else if (response.MessageDelta is { } messageDelta)
            {
                update.FinishReason = messageDelta.Delta.StopReason is { } reason ? ToFinishReason(reason) : null;
                if (messageDelta.Delta.StopSequence is { } stopSequence)
                    (update.AdditionalProperties ??= [])[nameof(messageDelta.Delta.StopSequence)] = stopSequence;
                var counts = messageDelta.Usage;
                update.Contents.Add(usage.Update(counts.InputTokens, counts.OutputTokens,
                    counts.CacheCreationInputTokens, counts.CacheReadInputTokens));
            }

            update.ResponseId = responseId;
            update.MessageId = responseId;
            update.ModelId = modelId;
            yield return update;
        }
    }

    private static ChatFinishReason ToFinishReason(StopReason? reason) => reason switch
    {
        StopReason.EndTurn or StopReason.StopSequence => ChatFinishReason.Stop,
        StopReason.MaxTokens => ChatFinishReason.Length,
        StopReason.ToolUse => ChatFinishReason.ToolCalls,
        _ => new ChatFinishReason(reason?.ToString() ?? "unknown"),
    };

    private sealed class StreamingUsage
    {
        private int _input;
        private int _output;
        private int _cacheCreation;
        private int _cacheRead;

        public UsageContent Update(int? input, int output, int? cacheCreation, int? cacheRead)
        {
            // Anthropic reports cumulative totals; MEAI aggregates additive usage updates.
            var inputDelta = (input ?? _input) - _input;
            var outputDelta = output - _output;
            UsageDetails details = new()
            {
                InputTokenCount = inputDelta,
                OutputTokenCount = outputDelta,
                TotalTokenCount = inputDelta + outputDelta,
            };
            if (cacheCreation is { } creation)
            {
                (details.AdditionalCounts ??= [])[nameof(Usage.CacheCreationInputTokens)] = creation - _cacheCreation;
                _cacheCreation = creation;
            }
            if (cacheRead is { } read)
            {
                (details.AdditionalCounts ??= [])[nameof(Usage.CacheReadInputTokens)] = read - _cacheRead;
                _cacheRead = read;
            }
            _input = input ?? _input;
            _output = output;
            return new UsageContent(details);
        }
    }

    private CreateMessageParams CreateRequest(IEnumerable<ChatMessage> chatMessages, ChatOptions? options)
    {
        if (options?.Temperature is not null || options?.TopP is not null || options?.TopK is not null)
        {
            throw new NotSupportedException("Anthropic API version 2026-10-21 does not support Temperature, TopP or TopK. Omit these options.");
        }

        string? systemMessage = null;

        List<InputMessageUnion> messages = [];
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
                            },
                        }));
                        break;

                    case DataContent dc when dc.MediaType.Equals("application/pdf", StringComparison.OrdinalIgnoreCase):
                        if (chatMessage.Role == ChatRole.Assistant)
                        {
                            throw new NotSupportedException("Anthropic API version 2026-10-21 only accepts document blocks in user messages.");
                        }
                        blocks.Add(new InputContentBlock(new RequestDocumentBlock
                        {
                            Source = new Base64PDFSource
                            {
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
                        if (chatMessage.Role == ChatRole.Assistant)
                        {
                            throw new NotSupportedException("Anthropic API version 2026-10-21 only accepts document blocks in user messages.");
                        }
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
            }
            if (blocks.Count > 0)
            {
                messages.Add(chatMessage.Role == ChatRole.Assistant
                    ? InputMessageUnion.FromAssistant(new AssistantInputMessage { Content = new(null, blocks) })
                    : InputMessageUnion.FromUser(new UserInputMessage { Content = new(null, blocks) }));
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
                        tools.Add(new Tool5
                        {
                            Name = f.Name,
                            Description = f.Description,
                            InputSchema = f.JsonSchema.Clone(),
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

}
