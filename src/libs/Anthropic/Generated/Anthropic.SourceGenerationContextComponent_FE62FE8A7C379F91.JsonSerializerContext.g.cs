
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FE62FE8A7C379F91
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_06C0E1ED870DC15F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6C8DDF5ADC47CA3F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A718717C9CA2B87C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AE1590BCFEFE7DAF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C69FD75403343CE1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CE3547261F6526A3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Status4JsonConverter>(static () => new global::Anthropic.JsonConverters.Status4JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Status4))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0369.Create_Status42(options);
                }
                if (type == typeof(global::Anthropic.Status4?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0289.Create_NullableStatus42(options);
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