﻿using H.Generators.Extensions;

namespace Anthropic.Generators;

internal static partial class Sources
{
    /// <summary>
    /// https://swagger.io/docs/specification/data-models/data-types/
    /// </summary>
    /// <param name="parameter"></param>
    /// <param name="depth"></param>
    /// <param name="schema"></param>
    /// <returns></returns>
    public static string GenerateOpenApiSchema(OpenApiSchema parameter, int depth = 0, bool schema = true)
    {
        var indent = new string(' ', depth * 4);
        var name = schema ? "global::Anthropic.OpenApiSchema" : "global::Anthropic.ToolInputSchema";
        if (parameter.ArrayItem.Count != 0)
        {
            return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",
{indent}                        Description = ""{parameter.Description}"",
{indent}                        Items = {GenerateOpenApiSchema(parameter.ArrayItem.First(), depth: depth + 1)},
{indent}                    }}";
        }
        if (parameter.Properties.Count != 0)
        {
            return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",
{indent}                        Description = ""{parameter.Description}"",
{indent}                        Properties = new global::System.Collections.Generic.Dictionary<string, global::Anthropic.OpenApiSchema>
{indent}                        {{
{indent}                            {string.Join(",\n                            " + indent, parameter.Properties.Select(x => $@"[""{x.Name}""] = " + GenerateOpenApiSchema(x, depth: depth + 2)))}
{indent}                        }},
{indent}                        Required = new string[] {{ {string.Join(", ", parameter.Properties
                                    .Where(static x => x.IsRequired)
                                    .Select(static x => $"\"{x.Name}\""))} }},
{indent}                    }}";
        }
        
        if (parameter.EnumValues.Count != 0)
        {
            return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",
{indent}                        Description = ""{parameter.Description}"",
{indent}                        Enum = new string[] {{ {string.Join(", ", parameter.EnumValues.Select(static x => $"\"{x}\""))} }},
{indent}                    }}";
        }
        
        return $@"new {name}
{indent}                    {{
{indent}                        Type = ""{parameter.SchemaType}"",{(parameter.Format != null ? $@"
{indent}                        Format = ""{parameter.Format}""," : "")}
{indent}                        Description = ""{parameter.Description}"",
{indent}                    }}";
    }

    public static string GenerateClientImplementation(InterfaceData @interface)
    {
        var extensionsClassName = @interface.Name.Substring(startIndex: 1) + "Extensions";
        
        return @$"
#nullable enable

namespace {@interface.Namespace}
{{
    public static partial class {extensionsClassName}
    {{
        public static global::System.Collections.Generic.IList<global::Anthropic.Tool> AsTools(this {@interface.Name} functions)
        {{
            return new global::System.Collections.Generic.List<global::Anthropic.Tool>
            {{
{@interface.Methods.Select(method => $@"
                new global::Anthropic.Tool
                {{
                    Name = ""{method.Name}"",
                    Description = ""{method.Description}"",
                    InputSchema = {GenerateOpenApiSchema(method.Parameters, schema: false)},
                }},
").Inject()}
            }};
        }}
    }}
}}";
    }
}
