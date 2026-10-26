
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9A73BAF7BE3FED8B
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_090CD958D58F27CF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1A1C1249A59DEE06.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1B93A114215DF493.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_225F369404802873.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_236F6F7FB5F99A5C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2B431B94D199C21C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3A97CB3460DB54DC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4A0E8D5F8AECA4FE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4BA614755E0DC294.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4DEE9FCEC7290839.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4E16820272CDBD6E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_514805FF4893CAC0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_624893F0356F78FD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6B592A823D211692.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_72AE223665BA48F8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_72C3DF17EF7B810E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_72CCB0B33578DB8C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_786E14B106CAA40C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7D8C9D1E92C4999D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7E0BDDDC63AF96BB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_80D229F68D21CD4B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_90367A4E8ABDD942.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A73076E52F0ED2A4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A7484FF66670D711.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A7DAD87863395B25.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BE91CE0630512ECA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E5B8555865A2E091.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E62660E3C04FD4A2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EBCA0724B60964D2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F1A27D8EAF4CFC56.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F26951F9325E4B9D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F5475038DD2398D3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaResponseBrowserToolUseBlockUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaResponseBrowserToolUseBlockUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaResponseBrowserToolUseBlockUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0120.Create_BetaResponseBrowserToolUseBlockUnion2(options);
                }
                if (type == typeof(global::Anthropic.BetaResponseBrowserToolUseBlockUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0218.Create_NullableBetaResponseBrowserToolUseBlockUnion2(options);
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