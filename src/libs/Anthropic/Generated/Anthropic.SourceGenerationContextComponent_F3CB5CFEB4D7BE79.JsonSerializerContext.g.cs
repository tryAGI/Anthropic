
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F3CB5CFEB4D7BE79
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0FFC776943E3CB18.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_29D73F8B39C6E8E0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_382805C85A9882BA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4598B99310E86175.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_72FE83D64D08C148.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7CBC220FFACD8639.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A92E2162BD21E494.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F2784A6B8D8CEDDE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.MessageStreamEventJsonConverter>(static () => new global::Anthropic.JsonConverters.MessageStreamEventJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.MessageStreamEvent))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0192.Create_MessageStreamEvent2(options);
                }
                if (type == typeof(global::Anthropic.MessageStreamEvent?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0251.Create_NullableMessageStreamEvent2(options);
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