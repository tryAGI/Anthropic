
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_2F706896EF627396
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_006F5776DC2BFAFD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0AEBE43AD62F3D96.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1260A931A209BB8E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_13B1FD5211802E7D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_342D5607F9D04D28.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_38A2F0D8FD3F2E59.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3EBB435CF443351D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4800C55A6E1A0AEF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4DA2B05E94FE56A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_53D7D7D0AED7DFD5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_54F76A43BBB0DB1F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5D131555EC3DBF25.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6FDB50A0B654686B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_76EC0898F125DFC6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7C960DA0ED2F967A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7D876CE7E3A2FAE0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_85F95A3AFD563D84.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8BAD221F60DAA9EC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8D6FC42B2BE177EC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A30995A21CD75798.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A500AAA9837412A2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A745F69246A9C0F3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B5829C8E698B9F8B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BDCAFE66824D1134.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BE093505E8A75431.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C66275C675EB3B1A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D0C8A1237B507B24.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DCA20431A0CF6FBD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FC1A7972A9F88D3A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FD144B9CBBD7A435.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FD70F93B2992DEC0.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BrowserMemberInputJsonConverter>(static () => new global::Anthropic.JsonConverters.BrowserMemberInputJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BrowserMemberInput))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0153.Create_BrowserMemberInput2(options);
                }
                if (type == typeof(global::Anthropic.BrowserMemberInput?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0225.Create_NullableBrowserMemberInput2(options);
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