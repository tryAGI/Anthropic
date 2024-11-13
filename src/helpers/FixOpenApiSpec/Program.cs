using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(jsonOrYaml))
{
    jsonOrYaml = OpenApi31Support.ConvertToOpenApi30(jsonOrYaml);
}

var openApiDocument = new OpenApiStringReader().Read(jsonOrYaml, out var diagnostics);

openApiDocument.Servers.Clear();
openApiDocument.Servers.Add(new OpenApiServer
{
    Url = "https://api.anthropic.com/v1",
});

openApiDocument.Components.SecuritySchemes.Clear();
openApiDocument.Components.SecuritySchemes.Add("ApiKeyAuth", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.ApiKey,
    In = ParameterLocation.Header,
    Name = "x-api-key",
});

openApiDocument.SecurityRequirements.Clear();
openApiDocument.SecurityRequirements.Add(new OpenApiSecurityRequirement
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "ApiKeyAuth",
            },
        },
        new List<string>()
    }
});

// openApiDocument.Components.Schemas["TextBlock"].Properties["type"].Enum = new List<IOpenApiAny>
// {
//     new OpenApiString("text"),
// };
// openApiDocument.Components.Schemas["ImageBlock"].Properties["type"].Enum = new List<IOpenApiAny>
// {
//     new OpenApiString("image"),
// };
// openApiDocument.Components.Schemas["ToolUseBlock"]!.Properties["type"].Enum = new List<IOpenApiAny>
// {
//     new OpenApiString("tool_use"),
// };
// openApiDocument.Components.Schemas["ToolResultBlock"]!.Properties["type"].Enum = new List<IOpenApiAny>
// {
//     new OpenApiString("tool_result"),
// };
//
// openApiDocument.Components.Schemas["TextBlock"].Required.Add("type");
// openApiDocument.Components.Schemas["ImageBlock"].Required.Add("type");
// openApiDocument.Components.Schemas["ToolUseBlock"].Required.Add("type");
// openApiDocument.Components.Schemas["ToolResultBlock"].Required.Add("type");

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