namespace Anthropic;

/// <summary>
/// Metadata for chat models.
/// </summary>
public class ChatModelMetadata
{
    /// <summary>
    /// Price per training token in USD.
    /// </summary>
    public double? PricePerInputTokenInUsd { get; init; }
    
    /// <summary>
    /// Price per input token in USD.
    /// </summary>
    public double? PricePerOutputTokenInUsd { get; init; }
    
    /// <summary>
    /// Context length in tokens.
    /// </summary>
    public int? ContextLength { get; init; }
    
    /// <summary>
    /// Output length in tokens.
    /// </summary>
    public int? OutputLength { get; init; }
}