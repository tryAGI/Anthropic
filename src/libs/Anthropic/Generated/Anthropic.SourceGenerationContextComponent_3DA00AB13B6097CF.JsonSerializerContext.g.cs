
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3DA00AB13B6097CF
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_672AA6DF5A5CB561.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7A52CE261A0A2115.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DB2422F25DC6F984.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EC19C461AA3D4003.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F546F1DAB04BD4C4.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>>(static () => new global::Anthropic.JsonConverters.OneOfJsonConverter<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_3DA00AB13B6097CF(options);
                }
                if (type == typeof(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsEffortLow, global::Anthropic.BetaManagedAgentsEffortMedium, global::Anthropic.BetaManagedAgentsEffortHigh, global::Anthropic.BetaManagedAgentsEffortXhigh, global::Anthropic.BetaManagedAgentsEffortMax>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0309.Create_SourceGenerationContextMetadataType_C3BAF7979AB61302(options);
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