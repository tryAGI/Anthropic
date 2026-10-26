
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A6A1EE3471573602
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_04E271D70EC168B0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_10A1A486932DA32F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1E885DE2D51E25D6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2EAEA4BE4C7755B1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_411BE256829AA6B3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_45A62B8A118F3B50.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_621F4A00C44261A7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_66F496E5E08FB87C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7522569195F3CA75.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7A884CAD828E6FF1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7FC2F0B6B92506F5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_825D2EFA1E26AEA3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8C8069BBBA9C949E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9CE8E3F59C306C86.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D2793670391EB7AF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DD31B825E97099B8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EA78BBD1B4624E1C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsRunErrorJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsRunErrorJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsRunError))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0080.Create_BetaManagedAgentsRunError(options);
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