
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_561827C0FCE88B96
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_8C77E300FC7955E7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9635D1E4B084D691.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_98009F94E1ED6C60.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D4B0D09315090A81.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0275.Create_SourceGenerationContextMetadataType_561827C0FCE88B96(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.RequestTextEditorCodeExecutionToolResultError, global::Anthropic.RequestTextEditorCodeExecutionViewResultBlock, global::Anthropic.RequestTextEditorCodeExecutionCreateResultBlock, global::Anthropic.RequestTextEditorCodeExecutionStrReplaceResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0294.Create_SourceGenerationContextMetadataType_CE65DF1505DDA937(options);
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