
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_29139DD6C8FB6020
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2301033BE64FB516.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3721236FFDFAD152.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5508304F908B02E3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_555CC4E057212A75.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_88AB6495E257C655.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaIterationsUsageVariant1ItemJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaIterationsUsageVariant1ItemJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaIterationsUsageVariant1Item))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0043.Create_BetaIterationsUsageVariant1Item2(options);
                }
                if (type == typeof(global::Anthropic.BetaIterationsUsageVariant1Item?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0206.Create_NullableBetaIterationsUsageVariant1Item2(options);
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