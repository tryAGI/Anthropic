
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_64960D90A983B6E7
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0D18482F2875A7E8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1B933B54265E668D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1D0915DA10713CE6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4B65B869035B7321.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_69A7349AF18BEC55.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_82C994C84958671B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E782C9EECDA39BBD.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaMessageStreamEventJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaMessageStreamEventJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaMessageStreamEvent))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0098.Create_BetaMessageStreamEvent2(options);
                }
                if (type == typeof(global::Anthropic.BetaMessageStreamEvent?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0213.Create_NullableBetaMessageStreamEvent2(options);
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