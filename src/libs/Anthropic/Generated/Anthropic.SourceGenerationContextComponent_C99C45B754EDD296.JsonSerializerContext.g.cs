
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C99C45B754EDD296
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_32851F29FFF83331.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_496BDD9E1B2C0A89.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_60BD9450E961E9DA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8113C6D7A348B2CD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F86309F40BF31CAE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaTelemetryDestinationDisabledReasonJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaTelemetryDestinationDisabledReasonJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaTelemetryDestinationDisabledReason))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0132.Create_BetaTelemetryDestinationDisabledReason2(options);
                }
                if (type == typeof(global::Anthropic.BetaTelemetryDestinationDisabledReason?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0221.Create_NullableBetaTelemetryDestinationDisabledReason2(options);
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