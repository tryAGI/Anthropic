using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

// Add Ping event type (Anthropic sends ping SSE events but omits them from the spec)
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

// Simplify input_schema to free-form object for better SDK ergonomics
openApiDocument.Components.Schemas["Tool"]!.Properties!["input_schema"] = new OpenApiSchema
{
    Type = JsonSchemaType.Object,
};
openApiDocument.Components.Schemas["BetaTool"]!.Properties!["input_schema"] = new OpenApiSchema
{
    Type = JsonSchemaType.Object,
};

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
