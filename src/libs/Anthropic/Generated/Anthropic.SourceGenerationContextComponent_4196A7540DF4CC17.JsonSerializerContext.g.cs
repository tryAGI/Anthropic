
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4196A7540DF4CC17
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_085F185D538949F9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0C2017F2FBAD678E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1EA874EC07096219.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2019B6BA12BB7EF5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_50A3674F567A7CD6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5748666677CFC778.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_596F22C88C6B3B38.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_84FA26DABAED06E7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8CE7F70D4D9908C3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_90810775194542BF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_90A2D0C42C9C4FE1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A4563AD0E1109D05.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C521DF065DF94988.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CBF4009533241AD6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CFA7A3C4CDEB216F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D0A01A440CB52F19.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DFEDFA3F7CCBC0FA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F21EA374BC093491.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.AvailableToolsLimitExceededErrorDetails, global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.ClaudeCodeVersionTooOldErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.CmekKeyNetworkBlockedErrorDetails, global::Anthropic.CompactionBlockAmbiguousErrorDetails, global::Anthropic.CompactionBlockMisplacedErrorDetails, global::Anthropic.CompactionContentMismatchErrorDetails, global::Anthropic.CompactionIncompleteTurnErrorDetails, global::Anthropic.CompactionNothingToSummarizeErrorDetails, global::Anthropic.CompactionSignatureInvalidErrorDetails, global::Anthropic.CompactionTooManyToolReferencesErrorDetails, global::Anthropic.CompactionToolChangesMismatchErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails, global::Anthropic.RequestBodyEncodingInvalidErrorDetails, global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.ToolNameConflictErrorDetails, global::Anthropic.ToolReferenceUnresolvedErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.AvailableToolsLimitExceededErrorDetails, global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.ClaudeCodeVersionTooOldErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.CmekKeyNetworkBlockedErrorDetails, global::Anthropic.CompactionBlockAmbiguousErrorDetails, global::Anthropic.CompactionBlockMisplacedErrorDetails, global::Anthropic.CompactionContentMismatchErrorDetails, global::Anthropic.CompactionIncompleteTurnErrorDetails, global::Anthropic.CompactionNothingToSummarizeErrorDetails, global::Anthropic.CompactionSignatureInvalidErrorDetails, global::Anthropic.CompactionTooManyToolReferencesErrorDetails, global::Anthropic.CompactionToolChangesMismatchErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails, global::Anthropic.RequestBodyEncodingInvalidErrorDetails, global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.ToolNameConflictErrorDetails, global::Anthropic.ToolReferenceUnresolvedErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.AvailableToolsLimitExceededErrorDetails, global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.ClaudeCodeVersionTooOldErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.CmekKeyNetworkBlockedErrorDetails, global::Anthropic.CompactionBlockAmbiguousErrorDetails, global::Anthropic.CompactionBlockMisplacedErrorDetails, global::Anthropic.CompactionContentMismatchErrorDetails, global::Anthropic.CompactionIncompleteTurnErrorDetails, global::Anthropic.CompactionNothingToSummarizeErrorDetails, global::Anthropic.CompactionSignatureInvalidErrorDetails, global::Anthropic.CompactionTooManyToolReferencesErrorDetails, global::Anthropic.CompactionToolChangesMismatchErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails, global::Anthropic.RequestBodyEncodingInvalidErrorDetails, global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.ToolNameConflictErrorDetails, global::Anthropic.ToolReferenceUnresolvedErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0271.Create_SourceGenerationContextMetadataType_4196A7540DF4CC17(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.AvailableToolsLimitExceededErrorDetails, global::Anthropic.ClaudeCodeKeyCreatorNotMemberErrorDetails, global::Anthropic.ClaudeCodeVersionTooOldErrorDetails, global::Anthropic.CmekKeyDisabledErrorDetails, global::Anthropic.CmekKeyNetworkBlockedErrorDetails, global::Anthropic.CompactionBlockAmbiguousErrorDetails, global::Anthropic.CompactionBlockMisplacedErrorDetails, global::Anthropic.CompactionContentMismatchErrorDetails, global::Anthropic.CompactionIncompleteTurnErrorDetails, global::Anthropic.CompactionNothingToSummarizeErrorDetails, global::Anthropic.CompactionSignatureInvalidErrorDetails, global::Anthropic.CompactionTooManyToolReferencesErrorDetails, global::Anthropic.CompactionToolChangesMismatchErrorDetails, global::Anthropic.OrganizationOnHoldErrorDetails, global::Anthropic.RequestBodyEncodingInvalidErrorDetails, global::Anthropic.RequestBodyEncodingUnsupportedErrorDetails, global::Anthropic.ToolNameConflictErrorDetails, global::Anthropic.ToolReferenceUnresolvedErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_C7B9D4625B922003(options);
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