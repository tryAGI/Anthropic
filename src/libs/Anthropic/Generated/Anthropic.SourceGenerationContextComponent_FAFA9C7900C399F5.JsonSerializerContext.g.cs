
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FAFA9C7900C399F5
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_08E511278F6EF0EC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1D06C5B3D95F0E31.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1E28C56AE2C65539.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_201A7046D7DFA76B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2F9F0CB78F02F3FD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_31816FAE33397318.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_32C65746B7525A94.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_38868015B4E610B8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_60B816A3FBCD091C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6437A0D35126FF43.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6FC6EBF775032BDC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_78331D6047EDADCB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7D64E05728E1C363.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7FE52E0DCD92EED8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_81D7DA65CC73A654.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8C94CD691350E668.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9CF1FCE95A1C0D92.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9F6463F030F5CC94.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AB506E0E4AC42945.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AFEBEEE2DA3A1728.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B1FBBB29C94127CA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B2DDEA7B6298780D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C0C1E1AB4CA2F001.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C9D6A6FE5E4F961E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D031E8C2FD58B1A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D3906434811E1596.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D73DDD00E8974914.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D8B81726066D2BA8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DA2BB0B1C3F950E9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DFC359CB09BBD8A0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F0E7BF4E1800B4D3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaBrowserMemberInputJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaBrowserMemberInputJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaBrowserMemberInput))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0013.Create_BetaBrowserMemberInput2(options);
                }
                if (type == typeof(global::Anthropic.BetaBrowserMemberInput?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0199.Create_NullableBetaBrowserMemberInput2(options);
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