
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_80D9EA6B6AAF45D1
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_16CAB1E01793B148.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2186AAB9F73442B5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_34DE2F819BF81576.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3BE184439E06BF61.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3D24B87019C2EC3B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4AD5DB14A9B1ABA8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_507205187BB25A32.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6214B84907F7D240.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6A18E8A66F513013.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_713A98A752E69A4F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_75C21302BAC88516.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_78FF58B8477910DB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B0368F47C68CD3E3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B6BFED946501A819.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BE0925C57D05EC9D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E206C0892487E9E1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EFC464F0B82955D2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FF03EAC4919B0BA4.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaResponseComputerToolUseBlockUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaResponseComputerToolUseBlockUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaResponseComputerToolUseBlockUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0129.Create_BetaResponseComputerToolUseBlockUnion2(options);
                }
                if (type == typeof(global::Anthropic.BetaResponseComputerToolUseBlockUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0237.Create_NullableBetaResponseComputerToolUseBlockUnion2(options);
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