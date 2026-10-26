
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EA984960B65F6345
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item), static () => new global::Anthropic.JsonConverters.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1ItemJsonConverter());
            collector.AddEnum(typeof(global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item?), static () => new global::Anthropic.JsonConverters.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1ItemNullableJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0044.Create_BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item2(options);
                }
                if (type == typeof(global::Anthropic.BetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0198.Create_NullableBetaGetArtifactsV1OrganizationsAnalyticsArtifactsGetGroupByVariant1Item2(options);
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