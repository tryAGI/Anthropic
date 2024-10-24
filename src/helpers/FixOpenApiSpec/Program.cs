using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

var openApiDocument = new OpenApiStringReader().Read(jsonOrYaml, out var diagnostics);

openApiDocument.Components.Schemas["MessageStreamEvent"]!.Discriminator.Mapping["error"] = "#/components/schemas/ErrorEvent";

jsonOrYaml = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(jsonOrYaml, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, jsonOrYaml);