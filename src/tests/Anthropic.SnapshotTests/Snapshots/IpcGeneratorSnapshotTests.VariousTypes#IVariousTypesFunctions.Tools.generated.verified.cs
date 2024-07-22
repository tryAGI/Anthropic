//HintName: IVariousTypesFunctions.Tools.generated.cs

#nullable enable

namespace Anthropic.IntegrationTests
{
    public static partial class VariousTypesFunctionsExtensions
    {
        public static global::System.Collections.Generic.IList<global::Anthropic.Tool> AsTools(this IVariousTypesFunctions functions)
        {
            return new global::System.Collections.Generic.List<global::Anthropic.Tool>
            {
                new global::Anthropic.Tool
                {
                    Name = "GetCurrentWeather",
                    Description = "Get the current weather in a given location",
                    InputSchema = new global::Anthropic.OpenApiSchema
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::Anthropic.OpenApiSchema>
                        {
                            ["parameter1"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "integer",
                                Format = "int64",
                                Description = "",
                            },
                            ["parameter2"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "integer",
                                Format = "int32",
                                Description = "",
                            },
                            ["parameter3"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "number",
                                Format = "float",
                                Description = "",
                            },
                            ["parameter4"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "number",
                                Format = "double",
                                Description = "",
                            },
                            ["parameter5"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "boolean",
                                Description = "",
                            },
                            ["dateTime"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "string",
                                Format = "date-time",
                                Description = "",
                            },
                            ["date"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "string",
                                Format = "date",
                                Description = "",
                            }
                        },
                        Required = new string[] { "parameter1", "parameter2", "parameter3", "parameter4", "parameter5", "dateTime", "date" },
                    },
                },
            };
        }
    }
}