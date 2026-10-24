
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1A5B4277B3C879B8
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_1A9FF823256DD47E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_232FBC0BF23008CC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_61960E3F1237FE29.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BAEBE7E25D704C72.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadAgentEntryJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsSessionThreadAgentEntryJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0085.Create_BetaManagedAgentsSessionThreadAgentEntry2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsSessionThreadAgentEntry?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0210.Create_NullableBetaManagedAgentsSessionThreadAgentEntry2(options);
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