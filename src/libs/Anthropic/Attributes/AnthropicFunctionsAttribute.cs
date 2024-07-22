namespace Anthropic;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Interface)]
[System.Diagnostics.Conditional("ANTHROPIC_FUNCTIONS_ATTRIBUTES")]
public sealed class AnthropicFunctionsAttribute : Attribute;