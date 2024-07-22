using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Anthropic.Generators.Core.Conversion;

namespace H.Generators;

[Generator]
public class OpenAiFunctionsGenerator : IIncrementalGenerator
{
    #region Constants

    public const string Name = nameof(OpenAiFunctionsGenerator);
    public const string Id = "OAFG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var attributes =
            context.SyntaxProvider
                .ForAttributeWithMetadataName("Anthropic.AnthropicFunctionsAttribute")
                .SelectManyAllAttributesOfCurrentInterfaceSyntax()
                .SelectAndReportExceptions(PrepareData, context, Id);
        
        attributes
            .SelectAndReportExceptions(AsTools, context, Id)
            .AddSource(context);
        attributes
            .SelectAndReportExceptions(AsCalls, context, Id)
            .AddSource(context);
    }
    
    private static InterfaceData PrepareData(
        (SemanticModel SemanticModel, AttributeData AttributeData, InterfaceDeclarationSyntax InterfaceSyntax, INamedTypeSymbol InterfaceSymbol) tuple)
    {
        var (_, _, _, interfaceSymbol) = tuple;

        return interfaceSymbol.PrepareData();
    }
    
    private static FileWithName AsTools(InterfaceData @interface)
    {
        return new FileWithName(
            Name: $"{@interface.Name}.Tools.generated.cs",
            Text: Sources.GenerateClientImplementation(@interface));
    }
    
    private static FileWithName AsCalls(InterfaceData @interface)
    {
        return new FileWithName(
            Name: $"{@interface.Name}.Calls.generated.cs",
            Text: Sources.GenerateCalls(@interface));
    }

    #endregion
}