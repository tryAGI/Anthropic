
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A4AB299852D04D5E
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_213B5B5C19C1E001.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_228FE006926F0FC6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5F244863DB0A755E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9AC7D84DDFA6F741.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0305.Create_SourceGenerationContextMetadataType_A4AB299852D04D5E(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultError, global::Anthropic.BetaResponseTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaResponseTextEditorCodeExecutionStrReplaceResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0318.Create_SourceGenerationContextMetadataType_F1047AAD476BE290(options);
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