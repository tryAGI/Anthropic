
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C2E145E7CE8B05DA
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_09A8B8D971B6886E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_78F32C7B62C83223.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7DFA7F645B717E8C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_983174CECCEC3229.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D35FF745F7F0655F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F2F492B28C063F61.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.CitationsVariant1Item2JsonConverter>(static () => new global::Anthropic.JsonConverters.CitationsVariant1Item2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.CitationsVariant1Item2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0172.Create_CitationsVariant1Item22(options);
                }
                if (type == typeof(global::Anthropic.CitationsVariant1Item2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0246.Create_NullableCitationsVariant1Item22(options);
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