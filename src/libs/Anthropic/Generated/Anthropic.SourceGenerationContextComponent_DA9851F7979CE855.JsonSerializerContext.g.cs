
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_DA9851F7979CE855
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_15154E70D3ED5835.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_747C0F356D925EE9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E60037717C61D443.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F02E8B9989C6D0CD.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaTelemetryDestinationWorkspacesParamsJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaTelemetryDestinationWorkspacesParamsJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesParams))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0134.Create_BetaTelemetryDestinationWorkspacesParams2(options);
                }
                if (type == typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesParams?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0221.Create_NullableBetaTelemetryDestinationWorkspacesParams2(options);
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