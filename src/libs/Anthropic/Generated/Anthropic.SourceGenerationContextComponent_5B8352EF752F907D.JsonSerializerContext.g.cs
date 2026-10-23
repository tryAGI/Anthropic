
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5B8352EF752F907D
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_223E02C39E50AC36.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3A4681EE0496F4BB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_434D005F4D292756.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_45D6E59F2F896524.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_53D6BC241F3D82B6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_584051AB83F7E0CD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5BE4677D618BE875.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_75DA576CD699FAB2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_766CEDF877FC9E23.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_76BC4B5A122D0C87.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_76D1A398E5FA5E3F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_780068D34E1D3568.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7C3CECB3A47A5576.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_89BE579CAE12B2F8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8FFF893085C37874.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9129285CCDBE4A93.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9446AFA5591B8592.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9796E8935E9A409C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9B39C9E54264E165.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9CB14E4E29C66643.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A1CD5021EAC752B3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AA35D0909F869981.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AEE52FCAEF673B10.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB70DCB3733A6989.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C5B1F3BCA296AD97.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CF19EB1932DF0DF2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CFFD96ED4F1B323C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F32CD620B7CFF0A7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F629BA2EC82BACA1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F9FEB1E631454015.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FAA8C903C0B553D1.MetadataScope,
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
                if (type == typeof(global::Anthropic.BrowserToolsetConfigs))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0163.Create_BrowserToolsetConfigs(options);
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