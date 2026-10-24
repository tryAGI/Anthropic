
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_04B1992D66352E37
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_14396B5BA2C66952.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1AFFF4EE6B6C7F0B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4549B7AC617788F1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_80234CBFB6F18399.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AE4CBACE70C2C82E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C9E053C836107E97.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Delta2JsonConverter>(static () => new global::Anthropic.JsonConverters.Delta2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Delta2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0175.Create_Delta22(options);
                }
                if (type == typeof(global::Anthropic.Delta2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0230.Create_NullableDelta22(options);
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