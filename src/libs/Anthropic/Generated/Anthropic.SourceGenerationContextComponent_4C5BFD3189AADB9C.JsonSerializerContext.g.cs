
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4C5BFD3189AADB9C
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_7B2284A256ACE2A1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_878095C0609777C2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F39B7CF2F8B35677.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaExternalKeyChangedErrorDetails, global::Anthropic.BetaStorageChangedConcurrentlyErrorDetails, global::Anthropic.BetaWorkspaceChangedConcurrentlyErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaExternalKeyChangedErrorDetails, global::Anthropic.BetaStorageChangedConcurrentlyErrorDetails, global::Anthropic.BetaWorkspaceChangedConcurrentlyErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaExternalKeyChangedErrorDetails, global::Anthropic.BetaStorageChangedConcurrentlyErrorDetails, global::Anthropic.BetaWorkspaceChangedConcurrentlyErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0329.Create_SourceGenerationContextMetadataType_4C5BFD3189AADB9C(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaExternalKeyChangedErrorDetails, global::Anthropic.BetaStorageChangedConcurrentlyErrorDetails, global::Anthropic.BetaWorkspaceChangedConcurrentlyErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0347.Create_SourceGenerationContextMetadataType_A482868C8576DE29(options);
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