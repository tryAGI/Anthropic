
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_21047F4232549A94
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0A950E1FB2D1CAE6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D4D784870E4D151E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0266.Create_SourceGenerationContextMetadataType_21047F4232549A94(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.ResponseToolSearchToolResultError, global::Anthropic.ResponseToolSearchToolSearchResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0297.Create_SourceGenerationContextMetadataType_D91F629105F33253(options);
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