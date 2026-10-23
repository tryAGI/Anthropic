
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_507FC4B808898743
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2468AE9C3108214D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_25BE31E13B724C23.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_300045907483712E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_51DDF4444E1A389E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5500435699C33C89.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9C2AE42C5A05E3E6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A523ED17B54308F0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B3AA05947737406C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C739CB2D78BEDDB0.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.CountMessageTokensParams))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0179.Create_CountMessageTokensParams(options);
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