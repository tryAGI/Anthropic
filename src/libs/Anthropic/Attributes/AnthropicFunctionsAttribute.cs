namespace Anthropic;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Interface)]
[System.Diagnostics.Conditional("ANTHROPIC_TOOLS_ATTRIBUTES")]
public sealed class AnthropicToolsAttribute : Attribute;