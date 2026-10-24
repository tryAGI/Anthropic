
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A4B53702C89856A6
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0A5740B5F9C859C1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_123798E7375CE66C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_219F30FE49FACA06.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_389FB9071E053327.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3D3ECD89A208679A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9C5620C12BF4EF89.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A53B1742D2EA1AB4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E08FBAF990A11518.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsEventParamsJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsEventParamsJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsEventParams))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0065.Create_BetaManagedAgentsEventParams2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsEventParams?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0205.Create_NullableBetaManagedAgentsEventParams2(options);
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