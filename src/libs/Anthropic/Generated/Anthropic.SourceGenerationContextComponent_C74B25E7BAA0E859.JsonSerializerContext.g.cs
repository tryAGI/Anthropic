
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C74B25E7BAA0E859
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_1DCCDDE108056A30.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1FA9A72D15D92290.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3A7E52BE70BEDD21.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C7DBC687044CB09D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E87AF5A9E3CFC3EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F77AACC8931F20E9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ResourceJsonConverter>(static () => new global::Anthropic.JsonConverters.ResourceJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Resource))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0251.Create_Resource2(options);
                }
                if (type == typeof(global::Anthropic.Resource?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0235.Create_NullableResource2(options);
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