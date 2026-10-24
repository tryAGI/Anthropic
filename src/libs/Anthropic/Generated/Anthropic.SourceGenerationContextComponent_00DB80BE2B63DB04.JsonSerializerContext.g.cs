
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_00DB80BE2B63DB04
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_04205975B0C7AAE3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0E57FD06BD57C6E2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_177D0DF99BEAA71D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1940E88663D6C771.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1AF15E35F92E57FB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1C5DA8EC5DB6D4F6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_24A0A5BABE2C6FF7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2CBA2F1ABD74383E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3412838F2C8D3812.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3CF561864A8580AE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3E134CD6F5ABFD33.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3E4BB2F066CB76D8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3F32058BC61B33B7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5DA736142282945F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5E571F387CC120CB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6809D9753F1A1B3C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_847C40A6AFD6D4E7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_870690F1C90E1F6B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9152C36B3AEED4CC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_ACFDB69301CCA3C8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B1C65E46FC873C74.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B3920A2DA7EAF71E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B7345EB905ED7B9D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BAF34458ABB37C91.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB8AEA61FDD4FCCC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BC9F72D698331FA2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C4E0B3D23CD04821.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D638D07B0BAF5DBA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DC2D513C155E8F58.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E0E6CF3640148BE4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F8ED1848B9C1E90A.MetadataScope,
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
                if (type == typeof(global::Anthropic.BetaBrowserToolsetConfigs))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0017.Create_BetaBrowserToolsetConfigs(options);
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