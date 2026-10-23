
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9FC4675C219BCE86
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0DACE2A809C450DD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1801F815D9176CEC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_276AEC1FC1E042A5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_293107C4B5E2A17D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_29DFA6B1DD333688.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2DCB1A1E4679995A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3CE7285BC2335205.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3F38BE3DEAC74826.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_667BE69C900DA354.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A161317E7400DF77.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AECF2A996650E207.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CCF3FA2AD48B2881.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DE7ED97F8ED80B51.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0303.Create_SourceGenerationContextMetadataType_9FC4675C219BCE86(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaAvailableToolsLimitExceededErrorDetails, global::Anthropic.BetaClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.BetaCompactionBlockAmbiguousErrorDetails, global::Anthropic.BetaCompactionBlockMisplacedErrorDetails, global::Anthropic.BetaCompactionContentMismatchErrorDetails, global::Anthropic.BetaCompactionNothingToSummarizeErrorDetails, global::Anthropic.BetaCompactionSignatureInvalidErrorDetails, global::Anthropic.BetaCompactionToolChangesMismatchErrorDetails, global::Anthropic.BetaOrganizationOnHoldErrorDetails, global::Anthropic.BetaRequestBodyEncodingInvalidErrorDetails, global::Anthropic.BetaRequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.BetaToolNameConflictErrorDetails, global::Anthropic.BetaToolReferenceUnresolvedErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0304.Create_SourceGenerationContextMetadataType_A11BC596D4A30D26(options);
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