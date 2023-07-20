namespace Anthropic;

#pragma warning disable CS0618

/// <summary>
/// 
/// </summary>
public static class ApiHelpers
{
    /// <summary>
    /// According https://www-files.anthropic.com/production/images/model_pricing_july2023.pdf <br/>
    /// </summary>
    /// <param name="modelId"></param>
    /// <param name="completionTokens"></param>
    /// <param name="promptTokens"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double CalculatePriceInUsd(string modelId, int completionTokens, int promptTokens)
    {
        var promptPricePerToken = modelId switch
        {
            ModelIds.Claude => 11.02,
            
            ModelIds.ClaudeInstant => 1.63,
            
            _ => throw new NotImplementedException(),
        };
        var completionPricePerToken = modelId switch
        {
            ModelIds.Claude => 32.68,
            
            ModelIds.ClaudeInstant => 5.51,
            
            _ => throw new NotImplementedException(),
        } * 0.001 * 0.001;
        
        return completionTokens * completionPricePerToken +
               promptTokens * promptPricePerToken;
    }

    /// <summary>
    /// Calculates the maximum number of tokens possible to generate for a model. <br/>
    /// According https://docs.anthropic.com/claude/reference/selecting-a-model <br/>
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int CalculateContextLength(string modelId)
    {
        return modelId switch
        {
            ModelIds.Claude => 100_000,
            ModelIds.ClaudeInstant => 100_000,
            
            _ => throw new NotImplementedException(),
        };
    }
}