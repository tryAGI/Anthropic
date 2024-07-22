
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Anthropic
{
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::OpenApiGenerator.JsonConverters.CreateMessageRequestModelJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.CreateMessageRequestModelNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolChoiceTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ToolChoiceTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageRoleJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageRoleNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageBlockSourceMediaTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageBlockSourceMediaTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageBlockSourceTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.ImageBlockSourceTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StopReasonJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.StopReasonNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageStreamEventTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageStreamEventTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory4),
            typeof(global::OpenApiGenerator.JsonConverters.BlockJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.MessageStreamEventJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.BlockDeltaJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.JsonSerializerContextTypes))]
    internal sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}