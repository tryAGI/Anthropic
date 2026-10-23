
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3E14CA4C4D2B1FD2
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_37EE1DE797F93C59.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5981A6EB89DC8F98.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BABFA2B1E2C0B1BA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F88FC26BF47EFC22.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_3E14CA4C4D2B1FD2(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaRequestTextEditorCodeExecutionToolResultError, global::Anthropic.BetaRequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.BetaRequestTextEditorCodeExecutionStrReplaceResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0284.Create_SourceGenerationContextMetadataType_1B56DCD42A771E3C(options);
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