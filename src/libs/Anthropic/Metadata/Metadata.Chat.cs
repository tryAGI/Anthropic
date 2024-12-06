// ReSharper disable once CheckNamespace
namespace Anthropic;

public static partial class ModelMetadata
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static ChatModelMetadata GetChatModelMetadata(
        this ModelEnum model)
    {
        return model switch
        {
            ModelEnum.ClaudeInstant12 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 0.80 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 2.40 * UsdPerMillionTokens,
                ContextLength = 100_000,
            },
            
            ModelEnum.Claude20 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 8.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 24.00 * UsdPerMillionTokens,
                ContextLength = 100_000,
            },
            ModelEnum.Claude21 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 8.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 24.00 * UsdPerMillionTokens,
                ContextLength = 200_000,
            },
            ModelEnum.Claude3Sonnet20240229 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 3.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 15.00 * UsdPerMillionTokens,
                ContextLength = 200_000,
                OutputLength = 4_096,
            },
            
            ModelEnum.Claude3Opus20240229 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 15.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 75.00 * UsdPerMillionTokens,
                ContextLength = 200_000,
                OutputLength = 4_096,
            },
            
            ModelEnum.Claude3Haiku20240307 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 0.25 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 1.25 * UsdPerMillionTokens,
                ContextLength = 200_000,
                OutputLength = 4_096,
            },
            
            ModelEnum.Claude35Sonnet20240620 => new ChatModelMetadata
            {
                PricePerInputTokenInUsd = 3.00 * UsdPerMillionTokens,
                PricePerOutputTokenInUsd = 15.00 * UsdPerMillionTokens,
                ContextLength = 200_000,
                // https://docs.anthropic.com/en/docs/about-claude/models
                // 8192 output tokens is in beta and requires the header anthropic-beta: max-tokens-3-5-sonnet-2024-07-15. If the header is not specified, the limit is 4096 tokens.
                OutputLength = 4_096,
            },
            
            _ => new ChatModelMetadata(),
        };
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="inputTokens"></param>
    /// <param name="outputTokens"></param>
    /// <returns></returns>
    public static double? TryGetPriceInUsd(
        this ModelEnum model,
        int inputTokens,
        int outputTokens)
    {
        var metadata = model.GetChatModelMetadata();
        if (metadata.PricePerInputTokenInUsd == null ||
            metadata.PricePerOutputTokenInUsd == null)
        {
            return null;
        }
        
        return
            inputTokens * metadata.PricePerInputTokenInUsd +
            outputTokens * metadata.PricePerOutputTokenInUsd;
    }

    /// <inheritdoc cref="TryGetPriceInUsd(ModelEnum, int, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this ModelEnum model,
        int inputTokens,
        int outputTokens)
    {
        return model.TryGetPriceInUsd(inputTokens, outputTokens) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }
    
    /// <inheritdoc cref="GetOutputLength"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetContextLength(
        this ModelEnum model)
    {
        return model.GetChatModelMetadata().ContextLength ??
               throw new InvalidOperationException(
                   $"Context length is not available for {model.ToValueString()}.");
    }
    
    /// <inheritdoc cref="GetChatModelMetadata"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static int GetOutputLength(
        this ModelEnum model)
    {
        return model.GetChatModelMetadata().OutputLength ??
               throw new InvalidOperationException(
                   $"Output length is not available for {model.ToValueString()}.");
    }
}