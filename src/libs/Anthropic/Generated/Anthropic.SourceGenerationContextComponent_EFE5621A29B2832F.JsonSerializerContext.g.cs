
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EFE5621A29B2832F
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_604FBF68673B38E7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_65A83651C8BE9B6D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AE26B71A2C96D382.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B19D848F044FF77D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FB4E658D53AAA17A.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0317.Create_SourceGenerationContextMetadataType_EFE5621A29B2832F(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaExternalKeyValidationFailedErrorDetails, global::Anthropic.BetaExternalKeyValidationTimedOutErrorDetails, global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0289.Create_SourceGenerationContextMetadataType_5D9173FA21E50D72(options);
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