
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EAECBBA25C081001
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_25BE31E13B724C23.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_30BDD8C512D263E5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3F8936555CD48275.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_449F473AB1CB6205.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4A0CB99378DBF208.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4FDC45447A309CDB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5BD6379E600738B2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_63D63EAF504995E6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_67338A8BE17C515F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6B6DBAAA98A407AF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_86062131EED062D4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8BA961FEDEBFA741.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A41BFBD6E7739F2F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AF04BEB6CCB9E10B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C1BEFED703C966F1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D338208E8229E3EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E54D20D221003081.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EBDFBDE980C2F88C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F70C3B07807F19CC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FE824AB2DDEDEA4B.MetadataScope,
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
                if (type == typeof(global::Anthropic.BetaCreateMessageParams))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0033.Create_BetaCreateMessageParams(options);
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