//HintName: IWeatherFunctions.Tools.generated.cs

#nullable enable

namespace Anthropic.IntegrationTests
{
    public static partial class WeatherFunctionsExtensions
    {
        public static global::System.Collections.Generic.IList<global::Anthropic.Tool> AsTools(this IWeatherFunctions functions)
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
                            ["location"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "string",
                                Description = "The city and state, e.g. San Francisco, CA",
                            },
                            ["unit"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "string",
                                Description = "",
                                Enum = new string[] { "celsius", "fahrenheit" },
                            }
                        },
                        Required = new string[] { "location" },
                    },
                },

                new global::Anthropic.Tool
                {
                    Name = "GetCurrentWeatherAsync",
                    Description = "Get the current weather in a given location",
                    InputSchema = new global::Anthropic.OpenApiSchema
                    {
                        Type = "object",
                        Description = "Get the current weather in a given location",
                        Properties = new global::System.Collections.Generic.Dictionary<string, global::Anthropic.OpenApiSchema>
                        {
                            ["location"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "string",
                                Description = "The city and state, e.g. San Francisco, CA",
                            },
                            ["unit"] = new global::Anthropic.OpenApiSchema
                            {
                                Type = "string",
                                Description = "",
                                Enum = new string[] { "celsius", "fahrenheit" },
                            }
                        },
                        Required = new string[] { "location" },
                    },
                },
            };
        }
    }
}