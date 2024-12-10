using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

// ReSharper disable ConvertTypeCheckPatternToNullCheck
// ReSharper disable once CheckNamespace

namespace Anthropic;

public partial class AnthropicClient : IChatClient
{
    private static readonly JsonElement DefaultParameterSchema = JsonDocument.Parse("{}").RootElement;
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    ChatClientMetadata IChatClient.Metadata => _metadata ??= new(nameof(AnthropicClient), this.BaseUri);

    /// <inheritdoc />
    object? IChatClient.GetService(Type? serviceType, object? key)
    {
        return key is null && serviceType?.IsInstanceOfType(this) is true ? this : null;
    }

    async Task<ChatCompletion> IChatClient.CompleteAsync(
        IList<ChatMessage> chatMessages, ChatOptions? options, CancellationToken cancellationToken)
    {
        CreateMessageParams request = CreateRequest(chatMessages, options);

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

        ChatCompletion completion = new(responseMessage)
        {
            CompletionId = response.Id,
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

    async IAsyncEnumerable<StreamingChatCompletionUpdate> IChatClient.CompleteStreamingAsync(
        IList<ChatMessage> chatMessages, ChatOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        // TODO: Implement full streaming support. For now, it just yields the CompleteAsync result.

        ChatCompletion completion = await ((IChatClient)this).CompleteAsync(chatMessages, options, cancellationToken).ConfigureAwait(false);

        for (int i = 0; i < completion.Choices.Count; i++)
        {
            ChatMessage choice = completion.Choices[i];
            
            yield return new StreamingChatCompletionUpdate
            {
                AdditionalProperties = choice.AdditionalProperties,
                AuthorName = choice.AuthorName,
                ChoiceIndex = i,
                CompletionId = completion.CompletionId,
                Contents = choice.Contents,
                CreatedAt = completion.CreatedAt,
                FinishReason = completion.FinishReason,
                ModelId = completion.ModelId,
                RawRepresentation = choice.RawRepresentation,
                Role = choice.Role,
            };
        }

        if (completion.Usage is not null)
        {
            yield return new StreamingChatCompletionUpdate
            {
                Contents = [new UsageContent(completion.Usage)],
            };
        }
    }

    private static CreateMessageParams CreateRequest(IList<ChatMessage> chatMessages, ChatOptions? options)
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

            List<ContentVariant2Item2> blocks = [];
            foreach (var content in chatMessage.Contents)
            {
                switch (content)
                {
                    case TextContent tc:
                        blocks.Add(new ContentVariant2Item2(new RequestTextBlock { Text = tc.Text }));
                        break;

                    case ImageContent ic when ic.ContainsData:
                        blocks.Add(new ContentVariant2Item2(new RequestImageBlock
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
                                Data = ic.Data?.ToArray() ?? [], //Convert.ToBase64String(ic.Data?.ToArray() ?? []),
                                Type = Base64ImageSourceType.Base64,
                            }
                        }));
                        break;

                    case FunctionCallContent fcc:
                        blocks.Add(new ContentVariant2Item2(new RequestToolUseBlock
                        {
                            Id = fcc.CallId,
                            Name = fcc.Name,
                            Input = fcc.Arguments ?? new Dictionary<string, object?>(),
                        }));
                        break;

                    case FunctionResultContent frc:
                        blocks.Add(new ContentVariant2Item2(new RequestToolResultBlock
                        {
                            ToolUseId = frc.CallId,
                            Content = frc.Result?.ToString() ?? string.Empty,
                            IsError = frc.Exception is not null ? true : null,
                        }));
                        break;
                }

                foreach (ContentVariant2Item2 block in blocks)
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
                tools.OfType<AIFunction>().Select(f => new Tool
                {
                    Name = f.Metadata.Name,
                    Description = f.Metadata.Description,
                    InputSchema = CreateSchema(f),
                }).ToList() :
                null,
        };
        return request;
    }

    private static ToolParameterJsonSchema CreateSchema(AIFunction f)
    {
        var parameters = f.Metadata.Parameters;

        ToolParameterJsonSchema tool = new();

        foreach (AIFunctionParameterMetadata parameter in parameters)
        {
            tool.Properties.Add(parameter.Name, parameter.Schema is JsonElement e ? e : DefaultParameterSchema);

            if (parameter.IsRequired)
            {
                tool.Required.Add(parameter.Name);
            }
        }

        return tool;
    }
}