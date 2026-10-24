
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FF24218D1BD996F5
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
            collector.AddEnum(typeof(global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType), static () => new global::Anthropic.JsonConverters.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorTypeJsonConverter());
            collector.AddEnum(typeof(global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType?), static () => new global::Anthropic.JsonConverters.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorTypeNullableJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0003.Create_BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType2(options);
                }
                if (type == typeof(global::Anthropic.BetaAdvisorTool20260301CacheControlVariant1DiscriminatorType?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0190.Create_NullableBetaAdvisorTool20260301CacheControlVariant1DiscriminatorType2(options);
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