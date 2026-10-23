
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9EFA869842FDC7CE
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_8E751BE3BB60B72E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB0863E4910FAFAF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BBB38840E106978F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C902A059F1CCC170.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E424C8DBE6D6E7EE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsUserContentBlockJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsUserContentBlockJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsUserContentBlock))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0098.Create_BetaManagedAgentsUserContentBlock2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsUserContentBlock?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0230.Create_NullableBetaManagedAgentsUserContentBlock2(options);
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