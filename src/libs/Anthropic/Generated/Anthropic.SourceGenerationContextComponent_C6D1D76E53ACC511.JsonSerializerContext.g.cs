
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C6D1D76E53ACC511
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_16FF5FACE375C921.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_465C41ADA0EABF24.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_47D01B78FE490C6C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_47F4CE9D9E82C4E9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4B9908BAAF423A7D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_563AD1616870F153.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7A38BFA64888360A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7BDC66F6EE9EA4A7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7CC8C2497CE79D72.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B2932A6DA46F5D40.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E7CE4A6F272C24B4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EAB232C5156AE9C6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F745FD9A283334A6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaClientToolUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaClientToolUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaClientToolUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0023.Create_BetaClientToolUnion2(options);
                }
                if (type == typeof(global::Anthropic.BetaClientToolUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0194.Create_NullableBetaClientToolUnion2(options);
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