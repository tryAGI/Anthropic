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

openApiDocument.Components.Schemas.Add("Ping", new OpenApiSchema
{
    Type = "object",
    Properties = new Dictionary<string, OpenApiSchema>
    {
        ["type"] = new()
        {
            Enum = new List<IOpenApiAny>
            {
                new OpenApiString("ping"),
            },
            Type = "string",
            Default = new OpenApiString("ping"),
        },
    },
    Required = new HashSet<string>
    {
        "type",
    },
});
openApiDocument.Components.Schemas["MessageStreamEvent"].OneOf.Add(new OpenApiSchema
{
    Reference = new OpenApiReference
    {
        Type = ReferenceType.Schema,
        Id = "Ping",
    },
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