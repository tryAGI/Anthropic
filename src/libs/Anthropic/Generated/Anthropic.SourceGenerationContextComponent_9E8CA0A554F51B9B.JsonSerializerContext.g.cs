
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9E8CA0A554F51B9B
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0428C2B5651A48DF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7CCD70500E55C487.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_86D0EF87E13C7AA9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A6334C245B3A876E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A820F6F23432A684.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B19D848F044FF77D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D39B1C817FE75ADF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EC271809B131AE91.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaCmekNotApprovedErrorDetails, global::Anthropic.BetaExternalKeyNotFoundErrorDetails, global::Anthropic.BetaExternalKeyProviderMismatchErrorDetails, global::Anthropic.BetaGcpProjectNotVerifiedErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaRegionNotSupportedErrorDetails, global::Anthropic.BetaStorageNotApprovedErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaCmekNotApprovedErrorDetails, global::Anthropic.BetaExternalKeyNotFoundErrorDetails, global::Anthropic.BetaExternalKeyProviderMismatchErrorDetails, global::Anthropic.BetaGcpProjectNotVerifiedErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaRegionNotSupportedErrorDetails, global::Anthropic.BetaStorageNotApprovedErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaCmekNotApprovedErrorDetails, global::Anthropic.BetaExternalKeyNotFoundErrorDetails, global::Anthropic.BetaExternalKeyProviderMismatchErrorDetails, global::Anthropic.BetaGcpProjectNotVerifiedErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaRegionNotSupportedErrorDetails, global::Anthropic.BetaStorageNotApprovedErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0346.Create_SourceGenerationContextMetadataType_9E8CA0A554F51B9B(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaCmekNotApprovedErrorDetails, global::Anthropic.BetaExternalKeyNotFoundErrorDetails, global::Anthropic.BetaExternalKeyProviderMismatchErrorDetails, global::Anthropic.BetaGcpProjectNotVerifiedErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaRegionNotSupportedErrorDetails, global::Anthropic.BetaStorageNotApprovedErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0358.Create_SourceGenerationContextMetadataType_D548DC9F0064571F(options);
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