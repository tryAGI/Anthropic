
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6ED4D28C549E8135
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_6A05797B4E974100.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EA3ADEAF5DA2B83C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FA59E9AFA8BED176.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaExternalStorageInUseErrorDetails, global::Anthropic.BetaExternalStorageInWorkspacePolicyErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaExternalStorageInUseErrorDetails, global::Anthropic.BetaExternalStorageInWorkspacePolicyErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaExternalStorageInUseErrorDetails, global::Anthropic.BetaExternalStorageInWorkspacePolicyErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0337.Create_SourceGenerationContextMetadataType_6ED4D28C549E8135(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.BetaExternalStorageInUseErrorDetails, global::Anthropic.BetaExternalStorageInWorkspacePolicyErrorDetails, global::Anthropic.BetaInvalidStorageArnErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0332.Create_SourceGenerationContextMetadataType_56436F5F16E15B8D(options);
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