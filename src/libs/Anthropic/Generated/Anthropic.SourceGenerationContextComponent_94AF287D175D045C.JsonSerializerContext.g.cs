
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_94AF287D175D045C
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_009F3BF639ABF13A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_015AD97091658556.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_353034F484552256.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A852975AE60B4013.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0301.Create_SourceGenerationContextMetadataType_94AF287D175D045C(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseTextEditorCodeExecutionToolResultError, global::Anthropic.ResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.ResponseTextEditorCodeExecutionStrReplaceResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0294.Create_SourceGenerationContextMetadataType_63623C45181B5813(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}