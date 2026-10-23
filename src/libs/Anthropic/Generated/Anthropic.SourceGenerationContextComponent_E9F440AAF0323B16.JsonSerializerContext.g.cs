
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E9F440AAF0323B16
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_00CC61CEB9D7FAE5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_027807F7722C06A6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_064C952818D82E64.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_105989F7D726DA73.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_186627E50D7D6536.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1DFE933CDC2C6D03.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_235A0C0EE864DE4C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2C66A9B8D5C25437.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_305C61AC159959DF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_32E779704CD440FA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_38566E46C84510A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3894A5EB1A22AA70.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3BD2AF578E1B9E99.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4670A551F1D73B1D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5168A4244251882F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_53CFC07BA270A142.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_57FEE1501C1D842C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_58A8ABAB38E4A59D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_592CA0D0FB0E2576.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_637C8026FC493680.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_65FECD3A7501930D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6A60BF9B5D7C38E4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6C137367CF3905D7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6FB1B2E46D3A7197.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_788236195C026E24.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_792B81EDE6AFD751.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7AC181B59672D71A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7F817CA123475715.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7FC255EB1C578778.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_88B31326AE3FE9A5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8F621A0905A0A256.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_90FFA9C3AE73D869.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9B98B56DA9109419.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9BD8093363CFE793.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A0EAEDF1BB470C10.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A2142A2814E6855A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C4E2C965A891220E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C6B926F197AA631D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D0BB4F91A6E4C35F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D50E76E60B793A42.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D511DE188DEB6E41.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D69634E666D2964F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E2110A78B9D19F76.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F6138E07D68A6A28.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F73D421F39C968F6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsStreamSessionEventsJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsStreamSessionEventsJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsStreamSessionEvents))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0092.Create_BetaManagedAgentsStreamSessionEvents2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsStreamSessionEvents?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0227.Create_NullableBetaManagedAgentsStreamSessionEvents2(options);
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