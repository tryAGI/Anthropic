
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_793509CE0A5797EA
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_04D943D89CB42E3E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2C0F24F4013397EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_38F8690D372D2A8B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7BB9556C6B167CE0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_98822D0A719A7749.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C362E69CB0BDD10B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F21AD841AAF02036.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaAlreadyMemberErrorDetails, global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.BetaEmailDomainNotAllowedErrorDetails, global::Anthropic.BetaInviteAlreadyExistsErrorDetails, global::Anthropic.BetaOrgMemberLimitExceededErrorDetails, global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaAlreadyMemberErrorDetails, global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.BetaEmailDomainNotAllowedErrorDetails, global::Anthropic.BetaInviteAlreadyExistsErrorDetails, global::Anthropic.BetaOrgMemberLimitExceededErrorDetails, global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaAlreadyMemberErrorDetails, global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.BetaEmailDomainNotAllowedErrorDetails, global::Anthropic.BetaInviteAlreadyExistsErrorDetails, global::Anthropic.BetaOrgMemberLimitExceededErrorDetails, global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0298.Create_SourceGenerationContextMetadataType_793509CE0A5797EA(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaAlreadyMemberErrorDetails, global::Anthropic.BetaCannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.BetaEmailDomainNotAllowedErrorDetails, global::Anthropic.BetaInviteAlreadyExistsErrorDetails, global::Anthropic.BetaOrgMemberLimitExceededErrorDetails, global::Anthropic.BetaRbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.BetaRbacGroupOwnerAccessUnconfirmedErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0301.Create_SourceGenerationContextMetadataType_91D6B8BEF66FD9A1(options);
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