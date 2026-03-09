using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

openApiDocument.Components!.Schemas!.Add("Ping", new OpenApiSchema
{
    Type = JsonSchemaType.Object,
    Properties = new Dictionary<string, IOpenApiSchema>
    {
        ["type"] = new OpenApiSchema
        {
            Enum = [JsonValue.Create("ping")],
            Type = JsonSchemaType.String,
            Default = JsonValue.Create("ping"),
        },
    },
    Required = new HashSet<string>
    {
        "type",
    },
});
openApiDocument.Components.Schemas["MessageStreamEvent"]!.OneOf!.Add(
    new OpenApiSchemaReference("Ping", openApiDocument));
((OpenApiSchema)openApiDocument.Components.Schemas["ResponseTextBlock"]!).Required!.Remove("citations");

((OpenApiSchema)openApiDocument.Components.Schemas["Tool"]!.Properties!["input_schema"]!).AllOf!.Clear();
((OpenApiSchema)openApiDocument.Components.Schemas["Tool"]!.Properties!["input_schema"]!).Type = JsonSchemaType.Object;
((OpenApiSchema)openApiDocument.Components.Schemas["BetaTool"]!.Properties!["input_schema"]!).AllOf!.Clear();
((OpenApiSchema)openApiDocument.Components.Schemas["BetaTool"]!.Properties!["input_schema"]!).Type = JsonSchemaType.Object;

((OpenApiSchema)openApiDocument.Components.Schemas["InputMessage"]!).Discriminator = null;
((OpenApiSchema)openApiDocument.Components.Schemas["BetaInputMessage"]!).Discriminator = null;

((OpenApiSchema)openApiDocument.Components.Schemas["Usage"]!).Required!.Remove("server_tool_use");

openApiDocument.Components.SecuritySchemes!.Clear();
openApiDocument.Components.SecuritySchemes.Add("ApiKeyAuth", new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.ApiKey,
    In = ParameterLocation.Header,
    Name = "x-api-key",
});

openApiDocument.Security =
[
    new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecuritySchemeReference("ApiKeyAuth", openApiDocument),
            new List<string>()
        }
    }
];

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
