
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_88AECAA753C6C985
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_6DE7A04C8458B532.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7230F4454BB13191.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A910564E1945EA4B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D56EE69D51C58BBC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D5F85F21F828AF18.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FD16756F5AF9059D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Status2JsonConverter>(static () => new global::Anthropic.JsonConverters.Status2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Status2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0368.Create_Status22(options);
                }
                if (type == typeof(global::Anthropic.Status2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0289.Create_NullableStatus22(options);
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