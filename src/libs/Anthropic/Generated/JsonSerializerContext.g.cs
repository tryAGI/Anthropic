
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Anthropic.JsonConverters.CreateMessageRequestModelJsonConverter),
            typeof(global::Anthropic.JsonConverters.CreateMessageRequestModelNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.CacheControlEphemeralTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.ImageBlockSourceMediaTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.ImageBlockSourceMediaTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.ImageBlockSourceTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.ImageBlockSourceTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.BlockDiscriminatorTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.BlockDiscriminatorTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageRoleJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageRoleNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.StopReasonJsonConverter),
            typeof(global::Anthropic.JsonConverters.StopReasonNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.ToolChoiceTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.ToolChoiceTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageBatchProcessingStatusJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageBatchProcessingStatusNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageBatchTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageBatchTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageStreamEventTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageStreamEventTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.BlockDeltaDiscriminatorTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.BlockDeltaDiscriminatorTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageStreamEventDiscriminatorTypeJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageStreamEventDiscriminatorTypeNullableJsonConverter),
            typeof(global::Anthropic.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::Anthropic.JsonConverters.OneOfJsonConverterFactory2),
            typeof(global::Anthropic.JsonConverters.BlockJsonConverter),
            typeof(global::Anthropic.JsonConverters.ToolJsonConverter),
            typeof(global::Anthropic.JsonConverters.MessageStreamEventJsonConverter),
            typeof(global::Anthropic.JsonConverters.BlockDeltaJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anthropic.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}