
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9ED921BAA7F1EA97
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_38C10053636BE788.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5984E0CC33C13D2C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_721830B445E11722.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B9D0E82589C0526B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C2833437207D1B57.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CD446F168186EB46.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaGoogleManagedCmekRegionStatusJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaGoogleManagedCmekRegionStatusJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaGoogleManagedCmekRegionStatus))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0070.Create_BetaGoogleManagedCmekRegionStatus2(options);
                }
                if (type == typeof(global::Anthropic.BetaGoogleManagedCmekRegionStatus?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0248.Create_NullableBetaGoogleManagedCmekRegionStatus2(options);
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