using CSharpToJsonSchema;
using System.Text.Json.Serialization;

#pragma warning disable CA1002 // Do not expose generic lists
#pragma warning disable CA2227 // Collection properties should be read only

namespace Anthropic;

public partial class JsonSerializerContextTypes
{
    /// <summary>
    /// 
    /// </summary>
    public OpenApiSchema? OpenApiSchema { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public MessageStreamEvent? MessageStreamEvent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public JsonElement? JsonElement { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Dictionary<string, object?>? DictionaryStringObject { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ToolParameterJsonSchema? ToolParameterJsonSchema { get; set; }
}

/// <summary>
/// 
/// </summary>
public sealed class ToolParameterJsonSchema
{
    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "object";

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("required")]
    public List<string> Required { get; set; } = [];

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, JsonElement> Properties { get; set; } = [];
}