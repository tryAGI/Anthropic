
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F7A9D779CE3BBB36
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_05EFFFA5175028DF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2DA890EFE487711B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_352223D04A16412D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5FE8570D367E0D0C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6877FEBC33E583CC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BF4FAB0B562C9536.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DC8923C7CDAE0914.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ContentVariant2Item2JsonConverter>(static () => new global::Anthropic.JsonConverters.ContentVariant2Item2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ContentVariant2Item2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0179.Create_ContentVariant2Item22(options);
                }
                if (type == typeof(global::Anthropic.ContentVariant2Item2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0248.Create_NullableContentVariant2Item22(options);
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