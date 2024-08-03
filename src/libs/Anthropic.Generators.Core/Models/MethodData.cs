namespace Anthropic.Generators;

public readonly record struct MethodData(
    string Name,
    string Description,
    bool IsAsync,
    bool IsVoid,
    OpenApiSchema Parameters);