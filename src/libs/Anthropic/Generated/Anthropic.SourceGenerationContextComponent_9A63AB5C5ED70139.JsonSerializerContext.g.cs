
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9A63AB5C5ED70139
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2131A6E18FB89043.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_68811D2F5D37540D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_852C9909F5BE986B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B18C82878F3F9301.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C2FC84760D38EF6E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F8D48C4BCF9EECA6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FD46C8375679DA07.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Group4JsonConverter>(static () => new global::Anthropic.JsonConverters.Group4JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Group4))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0187.Create_Group42(options);
                }
                if (type == typeof(global::Anthropic.Group4?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0250.Create_NullableGroup42(options);
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