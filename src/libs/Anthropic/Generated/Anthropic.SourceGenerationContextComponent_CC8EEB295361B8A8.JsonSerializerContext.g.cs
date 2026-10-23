
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_CC8EEB295361B8A8
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_672AA6DF5A5CB561.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7A52CE261A0A2115.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D2045EEA49DE0607.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DB2422F25DC6F984.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EC19C461AA3D4003.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F546F1DAB04BD4C4.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsEffortJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsEffortJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsEffort))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0061.Create_BetaManagedAgentsEffort2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsEffort?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0213.Create_NullableBetaManagedAgentsEffort2(options);
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