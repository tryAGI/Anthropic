
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D237B603067F163A
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_4A6B6FF073C229AB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7505531E9323846E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7BE334FDAF9CFD63.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_90F9C64D3682B542.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9CEE531E06EAB06C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E1452CFECDE5DBE3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsWorkflowRunErrorJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsWorkflowRunErrorJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsWorkflowRunError))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0101.Create_BetaManagedAgentsWorkflowRunError2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsWorkflowRunError?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0231.Create_NullableBetaManagedAgentsWorkflowRunError2(options);
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