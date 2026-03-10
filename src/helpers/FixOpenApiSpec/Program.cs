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
openApiDocument.Components.Schemas["MessageStreamEvent"]!.Discriminator!.Mapping!.Add(
    "ping", new OpenApiSchemaReference("Ping", openApiDocument));
((OpenApiSchema)openApiDocument.Components.Schemas["ResponseTextBlock"]!).Required!.Remove("citations");

openApiDocument.Components.Schemas["Tool"]!.Properties!["input_schema"] = new OpenApiSchema
{
    Type = JsonSchemaType.Object,
};
openApiDocument.Components.Schemas["BetaTool"]!.Properties!["input_schema"] = new OpenApiSchema
{
    Type = JsonSchemaType.Object,
};

// Remove object defaults from caller properties that AutoSDK can't render as valid C#
foreach (var name in new[] { "ResponseToolUseBlock", "ResponseServerToolUseBlock", "ResponseWebFetchToolResultBlock", "ResponseWebSearchToolResultBlock" })
{
    if (openApiDocument.Components.Schemas[name]!.Properties!["caller"] is OpenApiSchema callerSchema)
    {
        callerSchema.Default = null;
    }
}

((OpenApiSchema)openApiDocument.Components.Schemas["InputMessage"]!).Discriminator = null;
((OpenApiSchema)openApiDocument.Components.Schemas["BetaInputMessage"]!).Discriminator = null;

((OpenApiSchema)openApiDocument.Components.Schemas["Usage"]!).Required!.Remove("server_tool_use");

openApiDocument.Components.SecuritySchemes = new Dictionary<string, IOpenApiSecurityScheme>();
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
