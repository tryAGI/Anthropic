
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_620707E681BEA52C
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_02164B0D8F0C94D6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_21A4EDFEE4C15EC5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_795006E488DFCB09.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_867B3F02C2919AAD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A1B9F6B860F5B0D8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C7CEA0292069C409.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Resource2JsonConverter>(static () => new global::Anthropic.JsonConverters.Resource2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Resource2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0261.Create_Resource22(options);
                }
                if (type == typeof(global::Anthropic.Resource2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0243.Create_NullableResource22(options);
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