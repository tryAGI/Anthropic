
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_44DD7AF68F53A921
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_15F4A80777D13B20.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2D78C247576FF5FF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8F8A3686E401A8C5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C95C99D2DC835A0E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D5B2BF63DAD2CA70.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D997F492D638969B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.CitationsVariant1Item3JsonConverter>(static () => new global::Anthropic.JsonConverters.CitationsVariant1Item3JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.CitationsVariant1Item3))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0189.Create_CitationsVariant1Item32(options);
                }
                if (type == typeof(global::Anthropic.CitationsVariant1Item3?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0257.Create_NullableCitationsVariant1Item32(options);
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