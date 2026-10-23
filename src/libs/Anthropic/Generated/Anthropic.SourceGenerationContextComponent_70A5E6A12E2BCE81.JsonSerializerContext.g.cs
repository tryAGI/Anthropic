
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_70A5E6A12E2BCE81
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0B2AEAA3090BF17E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_11449E37B8C9815A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_12FB7E5CE10D63B1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_21C9645DB61D770E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2A2F0E8CCD21E5D6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3923CC5B2D790338.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4472CE69BED12285.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5BDEAE3F2E102E45.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5D26DFA55572A441.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5E41B4246CAF2F40.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7F760CB92BD0F4CB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8082F60146104A40.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_92BE3E55215D5DE9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_931720D41FD6107B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9B695E25847B9E7C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9DDD7F406B542F21.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B4F96E8D8E965105.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B5C5BCDDF4DF1B14.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB6051C5A0A285AB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C150D154EE00A89A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D0FEDBA415B781A1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E635E374C8E3CFA4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_ED3B7E4D5C0A2B07.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F9856850F1D0AA91.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FF9E90A7109E4CF8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaInputContentBlockJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaInputContentBlockJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaInputContentBlock))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0042.Create_BetaInputContentBlock2(options);
                }
                if (type == typeof(global::Anthropic.BetaInputContentBlock?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0205.Create_NullableBetaInputContentBlock2(options);
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