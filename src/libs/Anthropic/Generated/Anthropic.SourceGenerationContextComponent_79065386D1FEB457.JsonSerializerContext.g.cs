
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_79065386D1FEB457
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_774D5A9FDC205EAF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D4D784870E4D151E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.ToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0316.Create_SourceGenerationContextMetadataType_79065386D1FEB457(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.ToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0300.Create_SourceGenerationContextMetadataType_26306C7A21795885(options);
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