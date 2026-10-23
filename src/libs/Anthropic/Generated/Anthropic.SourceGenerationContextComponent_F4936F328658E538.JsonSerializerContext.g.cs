
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F4936F328658E538
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_07C08E3727AB1C06.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0ED4E2193DFC239F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1F5B92E343AA7B18.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_25276B4346E251A3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6E55D0E348A57AF8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_96F3AF0990EE7F85.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DEAC8A48699A8F79.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.AlreadyMemberErrorDetails, global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.EmailDomainNotAllowedErrorDetails, global::Anthropic.InviteAlreadyExistsErrorDetails, global::Anthropic.OrgMemberLimitExceededErrorDetails, global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.AlreadyMemberErrorDetails, global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.EmailDomainNotAllowedErrorDetails, global::Anthropic.InviteAlreadyExistsErrorDetails, global::Anthropic.OrgMemberLimitExceededErrorDetails, global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.AlreadyMemberErrorDetails, global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.EmailDomainNotAllowedErrorDetails, global::Anthropic.InviteAlreadyExistsErrorDetails, global::Anthropic.OrgMemberLimitExceededErrorDetails, global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0319.Create_SourceGenerationContextMetadataType_F4936F328658E538(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.AlreadyMemberErrorDetails, global::Anthropic.CannotInviteEmailsWithUnverifiedDomainsErrorDetails, global::Anthropic.EmailDomainNotAllowedErrorDetails, global::Anthropic.InviteAlreadyExistsErrorDetails, global::Anthropic.OrgMemberLimitExceededErrorDetails, global::Anthropic.RbacGroupGrantsOwnerAccessErrorDetails, global::Anthropic.RbacGroupOwnerAccessUnconfirmedErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0285.Create_SourceGenerationContextMetadataType_23EAAADB4CF71F99(options);
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