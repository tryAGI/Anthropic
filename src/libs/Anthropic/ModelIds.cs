namespace Anthropic;

// ReSharper disable InconsistentNaming
#pragma warning disable CA1707

/// <summary>
/// According https://docs.anthropic.com/claude/reference/selecting-a-model <br/>
/// We currently offer two families of models, both of which support 100,000 token context windows.
/// </summary>
public static class ModelIds
{ 
    /// <summary>
    /// Superior performance on tasks that require complex reasoning. <br/>
    /// Max tokens: 100,000 tokens <br/>
    /// Training data: Up to February 2023 <br/>
    /// </summary>
    public const string Claude = "claude-2";
    
    /// <summary>
    /// Low-latency, high throughout. <br/>
    /// Max tokens: 100,000 tokens <br/>
    /// Training data: Up to February 2023 <br/>
    /// </summary>
    public const string ClaudeInstant = "claude-instant-1";
}