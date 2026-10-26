
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_781741A1793E340F
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_4C93D940427A028F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_58F9469F10290FC5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8364C8EF880D3564.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_96F20F1851EC4345.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B534AF809A74784D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C15C1C3850BE1E20.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventStopReasonJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventStopReasonJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0084.Create_BetaManagedAgentsSessionStatusIdleEventStopReason2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0210.Create_NullableBetaManagedAgentsSessionStatusIdleEventStopReason2(options);
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