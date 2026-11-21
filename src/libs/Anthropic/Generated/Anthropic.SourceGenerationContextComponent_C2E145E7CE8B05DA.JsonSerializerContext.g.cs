
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C2E145E7CE8B05DA
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_3A4F7C79706494CF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6FE63A2978DE30E0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A54EDCEE7C83BFEE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A5BA85F6C30C08EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A892E77DBF6BB78E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F5B5ECB85481A55E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.CitationsVariant1Item2JsonConverter>(static () => new global::Anthropic.JsonConverters.CitationsVariant1Item2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.CitationsVariant1Item2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0189.Create_CitationsVariant1Item22(options);
                }
                if (type == typeof(global::Anthropic.CitationsVariant1Item2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0257.Create_NullableCitationsVariant1Item22(options);
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