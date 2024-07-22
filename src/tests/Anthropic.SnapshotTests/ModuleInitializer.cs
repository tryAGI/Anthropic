using System.Runtime.CompilerServices;
using VerifyTests;

namespace H.Generators.IntegrationTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifySourceGenerators.Initialize();
    }
}