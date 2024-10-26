using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

var openApiDocument = new OpenApiStringReader().Read(jsonOrYaml, out var diagnostics);

openApiDocument.Components.Schemas["TextBlock"].Properties["type"].Enum = new List<IOpenApiAny>
{
    new OpenApiString("text"),
};
openApiDocument.Components.Schemas["ImageBlock"].Properties["type"].Enum = new List<IOpenApiAny>
{
    new OpenApiString("image"),
};
openApiDocument.Components.Schemas["ToolUseBlock"]!.Properties["type"].Enum = new List<IOpenApiAny>
{
    new OpenApiString("tool_use"),
};
openApiDocument.Components.Schemas["ToolResultBlock"]!.Properties["type"].Enum = new List<IOpenApiAny>
{
    new OpenApiString("tool_result"),
};

openApiDocument.Components.Schemas["TextBlock"].Required.Add("type");
openApiDocument.Components.Schemas["ImageBlock"].Required.Add("type");
openApiDocument.Components.Schemas["ToolUseBlock"].Required.Add("type");
openApiDocument.Components.Schemas["ToolResultBlock"].Required.Add("type");

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