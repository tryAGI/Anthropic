
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4B78ED835756123F
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_079A93EA66EDDAEF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_08B5B889C580A463.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_11A278CA88E95612.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_26C1C5737F19144F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_35F79CF74C6F03B8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5DE7A63FC22E30FC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C648F58B439970A2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D62D25AED283CD37.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ClientToolUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.ClientToolUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ClientToolUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0165.Create_ClientToolUnion2(options);
                }
                if (type == typeof(global::Anthropic.ClientToolUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0227.Create_NullableClientToolUnion2(options);
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