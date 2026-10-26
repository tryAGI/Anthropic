
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_CE48E2C00E23B1D5
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_03B4EBC31E7D7B9C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0CB49EFBDC5EB28B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0FFEB618B23E5F61.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1229AC4690BAB34F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1AC401DF39C55173.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1E890206A8F436B6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_23619D0C044A3F60.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_25BE4DF42BCC6B7A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2F759607CD2BCF58.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3BE4007730E82CAC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_53C3D11D382B9802.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_54398C3DFC5FEF52.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_606408F15DC7A3B8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_67570EB02F496582.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_68F76658B5976467.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_70EAE481DC333386.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7D4F1E6CC6D7113A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8C165CBAD40472CF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8E0769516D75BB2D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A048B0468B5BFF8E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A650C726222C3147.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A9F041B32045B1A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B43765D27D1DA12F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B9E07EACC460A28A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C2C0E753C7203EC3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C41331C036252271.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D2B11908D73A2819.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D765E088E986EFAD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E542DA82DCEB8EEC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EEA7595556A21A7C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FCF299A9190EAB93.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FD910F5243A7DA30.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ResponseBrowserToolUseBlockUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.ResponseBrowserToolUseBlockUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ResponseBrowserToolUseBlockUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0253.Create_ResponseBrowserToolUseBlockUnion2(options);
                }
                if (type == typeof(global::Anthropic.ResponseBrowserToolUseBlockUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0235.Create_NullableResponseBrowserToolUseBlockUnion2(options);
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