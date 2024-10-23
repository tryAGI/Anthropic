using CSharpToJsonSchema;

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
}