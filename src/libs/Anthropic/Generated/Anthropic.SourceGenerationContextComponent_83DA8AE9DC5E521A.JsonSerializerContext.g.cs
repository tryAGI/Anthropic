
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_83DA8AE9DC5E521A
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2C96D67B48D2F043.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4591609DC71844A4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5E30E94A77251CA1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_865EF7C26EB1759F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_96885A3B72B48333.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A9779F349D5E0D8C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.SourceJsonConverter>(static () => new global::Anthropic.JsonConverters.SourceJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Source))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0279.Create_Source2_3(options);
                }
                if (type == typeof(global::Anthropic.Source?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0256.Create_NullableSource2_3(options);
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