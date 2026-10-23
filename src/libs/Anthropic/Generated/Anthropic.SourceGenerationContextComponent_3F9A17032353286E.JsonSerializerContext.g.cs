
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3F9A17032353286E
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_06E8D2EB9AF7720F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0C3599847EC20142.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2DB01067D02838D8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2F1941A00F8C690F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2F43D72F493FBB7E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3F9BD959D57B98F6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_44979FB36334A3B4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_645F3A81B3EA1604.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6C3870811FF7B531.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_81A06F781C751297.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9918426B58776013.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_99FFAC56C6A8A8D2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B61770E90C07966B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CAC507711A433900.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D979D06571A83516.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E2E9335664FC22DB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F45BF4002B5CF915.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F85BCAA939D5DBC3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FE5BAD9323DC8C2A.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ContentBlockJsonConverter>(static () => new global::Anthropic.JsonConverters.ContentBlockJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ContentBlock))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0178.Create_ContentBlock2_3(options);
                }
                if (type == typeof(global::Anthropic.ContentBlock?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0247.Create_NullableContentBlock2_3(options);
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