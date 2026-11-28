
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7B4E31436F0AB2C5
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_3A243F37FE0B99B9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5F3CFFC6C694DDCA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F4178F308B74EFE8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaContractSpendLimitReachedErrorDetails, global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaContractSpendLimitReachedErrorDetails, global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaContractSpendLimitReachedErrorDetails, global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0339.Create_SourceGenerationContextMetadataType_7B4E31436F0AB2C5(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaContractSpendLimitReachedErrorDetails, global::Anthropic.BetaEnforcedSpendLimitReachedErrorDetails, global::Anthropic.BetaRampLimitExceededErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0353.Create_SourceGenerationContextMetadataType_BEE54197FD359E7C(options);
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