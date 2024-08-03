using System.Runtime.CompilerServices;
using VerifyTests;

namespace Anthropic.SnapshotTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifySourceGenerators.Initialize();
    }
}