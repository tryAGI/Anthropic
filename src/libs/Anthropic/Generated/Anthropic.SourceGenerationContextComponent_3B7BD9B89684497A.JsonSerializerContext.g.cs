
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_3B7BD9B89684497A
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_43528F5AC9B0C2ED.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_864484D4CA503830.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_940AD4F6C1AD2A0C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9E1AB39B1CB1FDAE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D7048FE75EC821C3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FCDFBE3FB5195E97.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Source4JsonConverter>(static () => new global::Anthropic.JsonConverters.Source4JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Source4))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0279.Create_Source42(options);
                }
                if (type == typeof(global::Anthropic.Source4?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0256.Create_NullableSource42(options);
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