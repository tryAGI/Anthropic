using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

// ReSharper disable ConvertTypeCheckPatternToNullCheck
// ReSharper disable once CheckNamespace

namespace Anthropic;

public partial class AnthropicApi : IChatClient
{
    private static readonly JsonElement s_defaultParameterSchema = JsonDocument.Parse("{}").RootElement;
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    ChatClientMetadata IChatClient.Metadata => _metadata ??= new(nameof(AnthropicApi), this.BaseUri);

    /// <inheritdoc />
    TService? IChatClient.GetService<TService>(object? key) where TService : class => this as TService;

    async Task<ChatCompletion> IChatClient.CompleteAsync(
        IList<ChatMessage> chatMessages, ChatOptions? options, CancellationToken cancellationToken)
    {
        CreateMessageRequest request = CreateRequest(chatMessages, options);

        var response = await this.CreateMessageAsync(request, cancellationToken).ConfigureAwait(false);

        ChatMessage responseMessage = new()
        {
            Role = response.Role == MessageRole.Assistant ? ChatRole.Assistant : ChatRole.User,
            RawRepresentation = response,
        };

        if (response.StopSequence is not null)
        {
            (responseMessage.AdditionalProperties ??= [])[nameof(response.StopSequence)] = response.StopSequence;
        }

        if (response.Content.Value1 is string stringContents)
        {
            responseMessage.Contents.Add(new TextContent(stringContents));
        }
        else if (response.Content.Value2 is IList<Block> blocks)
        {
            foreach (var block in blocks)
            {
                if (block.IsText)
                {
                    responseMessage.Contents.Add(new TextContent(block.Text!.Text) { RawRepresentation = block.Text });
                }
                else if (block.IsImage)
                {
                    responseMessage.Contents.Add(new ImageContent(
                        block.Image!.Source.Data,
                        block.Image!.Source.MediaType switch
                        {
                            ImageBlockSourceMediaType.ImagePng => "image/png",
                            ImageBlockSourceMediaType.ImageGif => "image/gif",
                            ImageBlockSourceMediaType.ImageWebp => "image/webp",
                            _ => "image/jpeg",
                        })
                    {
                        RawRepresentation = block.Image
                    });
                }
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
                StopReason.EndTurn or StopReason.StopSequence => ChatFinishReason.Stop,
                StopReason.MaxTokens => ChatFinishReason.Length,
                StopReason.ToolUse => ChatFinishReason.ToolCalls,
                _ => new ChatFinishReason(response.StopReason.ToString()!),
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

            if (u.CacheCreationInputTokens is not null)
            {
                (completion.Usage.AdditionalProperties ??= [])[nameof(u.CacheCreationInputTokens)] = u.CacheCreationInputTokens;
            }

            if (u.CacheReadInputTokens is not null)
            {
                (completion.Usage.AdditionalProperties ??= [])[nameof(u.CacheReadInputTokens)] = u.CacheReadInputTokens;
            }
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

    private static CreateMessageRequest CreateRequest(IList<ChatMessage> chatMessages, ChatOptions? options)
    {
        string? systemMessage = null;

        List<Message> messages = [];
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

            List<Block> blocks = [];
            foreach (var content in chatMessage.Contents)
            {
                switch (content)
                {
                    case TextContent tc:
                        blocks.Add(new Block(new TextBlock() { Text = tc.Text }));
                        break;

                    case ImageContent ic when ic.ContainsData:
                        blocks.Add(new Block(new ImageBlock()
                        {
                            Source = new ImageBlockSource()
                            {
                                MediaType = ic.MediaType switch
                                {
                                    "image/png" => ImageBlockSourceMediaType.ImagePng,
                                    "image/gif" => ImageBlockSourceMediaType.ImageGif,
                                    "image/webp" => ImageBlockSourceMediaType.ImageWebp,
                                    _ => ImageBlockSourceMediaType.ImageJpeg,
                                },
                                Data = Convert.ToBase64String(ic.Data?.ToArray() ?? []),
                                Type = ImageBlockSourceType.Base64,
                            }
                        }));
                        break;

                    case FunctionCallContent fcc:
                        blocks.Add(new Block(new ToolUseBlock()
                        {
                            Id = fcc.CallId,
                            Name = fcc.Name,
                            Input = fcc.Arguments ?? new Dictionary<string, object?>(),
                        }));
                        break;

                    case FunctionResultContent frc:
                        blocks.Add(new Block(new ToolResultBlock()
                        {
                            ToolUseId = frc.CallId,
                            Content = frc.Result?.ToString() ?? string.Empty,
                            IsError = frc.Exception is not null ? true : null,
                        }));
                        break;
                }

                foreach (Block block in blocks)
                {
                    messages.Add(new Message()
                    {
                        Role = chatMessage.Role == ChatRole.Assistant ? MessageRole.Assistant : MessageRole.User,
                        Content = new([block])
                    });
                }
            }
        }

        var request = new CreateMessageRequest()
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
                options?.ToolMode is AutoChatToolMode ? new ToolChoice() { Type = ToolChoiceType.Auto } :
                options?.ToolMode is RequiredChatToolMode r ?
                    new ToolChoice()
                    {
                        Type = r.RequiredFunctionName is not null ? ToolChoiceType.Tool : ToolChoiceType.Any,
                        Name = r.RequiredFunctionName
                    } :
                null,
            Tools = options?.Tools is IList<AITool> tools ?
                tools.OfType<AIFunction>().Select(f => new Tool(new ToolCustom() 
                {
                    Name = f.Metadata.Name,
                    Description = f.Metadata.Description,
                    InputSchema = CreateSchema(f),
                })).ToList() :
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
            tool.Properties.Add(parameter.Name, parameter.Schema is JsonElement e ? e : s_defaultParameterSchema);

            if (parameter.IsRequired)
            {
                tool.Required.Add(parameter.Name);
            }
        }

        return tool;
    }
}