
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D04943C524A61319
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_65A83651C8BE9B6D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AE26B71A2C96D382.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B19D848F044FF77D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0309.Create_SourceGenerationContextMetadataType_D04943C524A61319(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaKeyProfileMismatchErrorDetails, global::Anthropic.BetaUserProfileNotFoundErrorDetails, global::Anthropic.BetaWorkspacePolicyViolationErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0291.Create_SourceGenerationContextMetadataType_6AE235F67648C51F(options);
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