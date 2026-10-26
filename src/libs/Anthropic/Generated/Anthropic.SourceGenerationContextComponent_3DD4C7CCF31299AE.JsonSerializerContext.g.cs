
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3DD4C7CCF31299AE
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_013C798384873FA4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_078C41B46265FFC6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_09C91B8FE903A444.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_16240598DF94C57D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3BA27B3BE5CA8E10.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3D76339B05DFA535.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6F917E5CAE68E556.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_84D1A54C1E75334F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8EC8823F9583672C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A2AD04A52FB6482E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B2766890AAB916EB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C173BDB3D0BA5447.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CC24B74AB0B6FAEB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CCF4027C9E3C29F1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E4E60467A3BB0FD6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F3E54E7535A98CF2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FAE88BD52A1A3758.MetadataScope,
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
                if (type == typeof(global::Anthropic.ComputerToolsetConfigs))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0170.Create_ComputerToolsetConfigs(options);
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