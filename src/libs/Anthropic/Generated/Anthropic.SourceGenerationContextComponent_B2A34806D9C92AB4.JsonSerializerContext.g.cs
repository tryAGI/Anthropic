
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B2A34806D9C92AB4
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_4BA383ADD0984AEB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5536ADA95FD0155D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_ADF8BD3D36CA89DE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D9445271DFDCA7EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E31C6FB389303BD3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E4978A699779B34B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E8D93E0B2723DDA6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaClaudeTagSettingSourceJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaClaudeTagSettingSourceJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaClaudeTagSettingSource))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0021.Create_BetaClaudeTagSettingSource(options);
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