
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F5F85A98CB427077
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_06A63DDDE8E6CEF7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0957614047201F33.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0F7A366E19E2B8C7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2BEA25B316E70A8C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3542F9B89AF6F27F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4CF436AF4AD01A2A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_74B7EE5FEC115142.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7E647EA25C947253.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_965A4EEEC13D9810.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E164BE467186B1DE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E2A97180FC110F0C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E6B57CC966F3A561.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FC35A305EDABA188.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ContentBlock2JsonConverter>(static () => new global::Anthropic.JsonConverters.ContentBlock2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ContentBlock2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0178.Create_ContentBlock22(options);
                }
                if (type == typeof(global::Anthropic.ContentBlock2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0247.Create_NullableContentBlock22(options);
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