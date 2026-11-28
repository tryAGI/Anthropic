
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FE065CBB69938C84
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_08CDEA510E64C146.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_25C7D739480781F6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2BA70D59F6BAAC0D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_604FBF68673B38E7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_65A83651C8BE9B6D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_76F7E1BEBA104DE6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8773E367DE30D1CA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A7EF34A31D38B62C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AE26B71A2C96D382.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B19D848F044FF77D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B3A23B0E0CB491D4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D39B1C817FE75ADF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DBD6B46EA042B84A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DE567D1F2884896C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EA3ADEAF5DA2B83C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F6085A5E47340A0C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FB4E658D53AAA17A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FEA75319192B1EEC.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaApprovalRequiredErrorDetails, global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaExternalStorageNotAvailableErrorDetails, global::Anthropic.BetaGrantRequiredErrorDetails, global::Anthropic.BetaHumanReviewNotAvailableErrorDetails, global::Anthropic.BetaHumanReviewOnWithExternalStorageErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaStorageAttachLimitReachedErrorDetails, global::Anthropic.BetaStorageNotAttachableErrorDetails, global::Anthropic.BetaStorageProfileMismatchErrorDetails, global::Anthropic.BetaStorageProfileStillRequiredErrorDetails, global::Anthropic.BetaStorageVerificationFailedErrorDetails, global::Anthropic.BetaTranscriptsStorageRequiredErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaApprovalRequiredErrorDetails, global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaExternalStorageNotAvailableErrorDetails, global::Anthropic.BetaGrantRequiredErrorDetails, global::Anthropic.BetaHumanReviewNotAvailableErrorDetails, global::Anthropic.BetaHumanReviewOnWithExternalStorageErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaStorageAttachLimitReachedErrorDetails, global::Anthropic.BetaStorageNotAttachableErrorDetails, global::Anthropic.BetaStorageProfileMismatchErrorDetails, global::Anthropic.BetaStorageProfileStillRequiredErrorDetails, global::Anthropic.BetaStorageVerificationFailedErrorDetails, global::Anthropic.BetaTranscriptsStorageRequiredErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaApprovalRequiredErrorDetails, global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaExternalStorageNotAvailableErrorDetails, global::Anthropic.BetaGrantRequiredErrorDetails, global::Anthropic.BetaHumanReviewNotAvailableErrorDetails, global::Anthropic.BetaHumanReviewOnWithExternalStorageErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaStorageAttachLimitReachedErrorDetails, global::Anthropic.BetaStorageNotAttachableErrorDetails, global::Anthropic.BetaStorageProfileMismatchErrorDetails, global::Anthropic.BetaStorageProfileStillRequiredErrorDetails, global::Anthropic.BetaStorageVerificationFailedErrorDetails, global::Anthropic.BetaTranscriptsStorageRequiredErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0367.Create_SourceGenerationContextMetadataType_FE065CBB69938C84(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaApprovalRequiredErrorDetails, global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaExternalStorageNotAvailableErrorDetails, global::Anthropic.BetaGrantRequiredErrorDetails, global::Anthropic.BetaHumanReviewNotAvailableErrorDetails, global::Anthropic.BetaHumanReviewOnWithExternalStorageErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaOrganizationNotEligibleErrorDetails, global::Anthropic.BetaStorageAttachLimitReachedErrorDetails, global::Anthropic.BetaStorageNotAttachableErrorDetails, global::Anthropic.BetaStorageProfileMismatchErrorDetails, global::Anthropic.BetaStorageProfileStillRequiredErrorDetails, global::Anthropic.BetaStorageVerificationFailedErrorDetails, global::Anthropic.BetaTranscriptsStorageRequiredErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0339.Create_SourceGenerationContextMetadataType_76A294D4DCBB07F8(options);
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