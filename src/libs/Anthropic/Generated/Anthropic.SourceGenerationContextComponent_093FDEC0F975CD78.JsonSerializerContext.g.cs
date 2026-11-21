
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_093FDEC0F975CD78
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_6A6F062A13C603DE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AB6F08561346008C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB5D28C31D53D5A3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0295.Create_SourceGenerationContextMetadataType_093FDEC0F975CD78(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.List<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0311.Create_SourceGenerationContextMetadataType_603551DA3B732178(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.RequestWebSearchResultBlock>, global::Anthropic.WebSearchToolRequestError>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0299.Create_SourceGenerationContextMetadataType_207C8F6E9BDD4CE0(options);
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