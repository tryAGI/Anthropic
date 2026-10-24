using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text.Json;

using var stream = File.OpenRead(args[0]);
using var pe = new PEReader(stream);
var reader = pe.GetMetadataReader();
var types = reader.TypeDefinitions.Select(h => reader.GetString(reader.GetTypeDefinition(h).Name)).ToHashSet(StringComparer.Ordinal);
var methods = reader.MethodDefinitions.Select(h => reader.GetString(reader.GetMethodDefinition(h).Name)).ToHashSet(StringComparer.Ordinal);
var unused = new[] { "ApiKeyUpdateParams", "BetaMessage", "BetaCreateMessageParams" };
var retained = unused.Where(name => types.Contains(name) || methods.Contains("Create_" + name)).ToArray();
var pdb = pe.ReadDebugDirectory().Where(e => e.Type == DebugDirectoryEntryType.EmbeddedPortablePdb).Sum(e => (long)e.DataSize);
Console.WriteLine(JsonSerializer.Serialize(new
{
    dllBytes = stream.Length, embeddedPdbBytes = pdb, bytesWithoutEmbeddedPdbPayload = stream.Length - pdb,
    metadataBytes = pe.PEHeaders.CorHeader!.MetadataDirectory.Size,
    ilBytes = reader.MethodDefinitions.Sum(h => { var m = reader.GetMethodDefinition(h); return m.RelativeVirtualAddress == 0 ? 0L : pe.GetMethodBody(m.RelativeVirtualAddress).GetILBytes()?.LongLength ?? 0; }),
    typeCount = types.Count, methodCount = reader.MethodDefinitions.Count, unusedModelsRetained = retained,
}));
if (!args.Skip(1).SequenceEqual(["--report-only"]) && retained.Length != 0)
    throw new InvalidOperationException("Unused models/factories retained: " + string.Join(", ", retained));
