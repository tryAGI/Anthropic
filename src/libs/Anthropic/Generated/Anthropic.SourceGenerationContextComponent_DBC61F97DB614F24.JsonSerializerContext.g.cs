
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_DBC61F97DB614F24
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_5198423792557358.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_931720D41FD6107B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB6051C5A0A285AB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C031FDC521FFAD55.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D0FEDBA415B781A1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F345DCDB66807079.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F9856850F1D0AA91.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ContentVariant2ItemJsonConverter>(static () => new global::Anthropic.JsonConverters.ContentVariant2ItemJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ContentVariant2Item))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0179.Create_ContentVariant2Item2_3(options);
                }
                if (type == typeof(global::Anthropic.ContentVariant2Item?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0248.Create_NullableContentVariant2Item2_3(options);
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