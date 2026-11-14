
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A6F25028645494C4
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_55F22FB38E1E4377.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5EBF7F8008B51007.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB86DC2EDF8CD625.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails, global::Anthropic.BetaCannotSignOutSelfErrorDetails, global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails, global::Anthropic.BetaCannotSignOutSelfErrorDetails, global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails, global::Anthropic.BetaCannotSignOutSelfErrorDetails, global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0313.Create_SourceGenerationContextMetadataType_A6F25028645494C4(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaCannotSignOutPrimaryOwnerErrorDetails, global::Anthropic.BetaCannotSignOutSelfErrorDetails, global::Anthropic.BetaOrganizationNotEnrolledInBetaErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0303.Create_SourceGenerationContextMetadataType_6E36B5B2597FE2F5(options);
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