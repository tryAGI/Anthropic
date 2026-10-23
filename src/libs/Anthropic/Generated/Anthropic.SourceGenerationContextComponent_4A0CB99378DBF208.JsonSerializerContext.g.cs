
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4A0CB99378DBF208
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2F2993701B4B21D1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3C72FDD605F0D570.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_958C007721F8B91F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D5B256B16AF00AAC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F3797B3171C361E3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaThinkingConfigParamJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaThinkingConfigParamJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaThinkingConfigParam))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0144.Create_BetaThinkingConfigParam2(options);
                }
                if (type == typeof(global::Anthropic.BetaThinkingConfigParam?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0241.Create_NullableBetaThinkingConfigParam2(options);
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