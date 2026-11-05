
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0767061DA030B6F5
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_09F6D9B5C9E07890.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0D8DA4C3E6DEAA9F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_15803B8BCA264C1C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_326871AFB24D9E63.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails, global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails, global::Anthropic.BetaCannotSignOutOwnerErrorDetails, global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails, global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails, global::Anthropic.BetaCannotSignOutOwnerErrorDetails, global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails, global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails, global::Anthropic.BetaCannotSignOutOwnerErrorDetails, global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0274.Create_SourceGenerationContextMetadataType_0767061DA030B6F5(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaCannotSignOutManagedMemberErrorDetails, global::Anthropic.BetaCannotSignOutMembershipAdminErrorDetails, global::Anthropic.BetaCannotSignOutOwnerErrorDetails, global::Anthropic.BetaCannotSignOutPrivilegedMemberErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0312.Create_SourceGenerationContextMetadataType_D819C4526EE770CE(options);
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