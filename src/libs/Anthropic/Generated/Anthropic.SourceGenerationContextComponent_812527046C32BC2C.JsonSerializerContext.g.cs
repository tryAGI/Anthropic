
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_812527046C32BC2C
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_25BE31E13B724C23.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_26A414CF97709F5E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_449F473AB1CB6205.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4A0CB99378DBF208.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4FDC45447A309CDB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_67338A8BE17C515F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6B6DBAAA98A407AF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_86062131EED062D4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A1638AF1CDEF5C94.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C1BEFED703C966F1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E54D20D221003081.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F70C3B07807F19CC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FA2D71D75A5EB9C6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaCountMessageTokensParams))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0026.Create_BetaCountMessageTokensParams(options);
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