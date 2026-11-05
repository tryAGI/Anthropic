
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_310EF7B87325827E
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0DB77DB230B6213B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_578B6737A26F3F10.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CD99D8D62BA0B4A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E875E82F7D64330B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0281.Create_SourceGenerationContextMetadataType_310EF7B87325827E(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0275.Create_SourceGenerationContextMetadataType_0D75CA0496486782(options);
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