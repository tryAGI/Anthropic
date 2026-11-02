
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_518ED18218C15197
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_19C035835CC0EB59.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2D41B77D24287CB6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3805B1BC2731230C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_67338A8BE17C515F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_93DCBFCC81B83934.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9FAEEA8172AE01B2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B83BA6A05F2332B5.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaUsage))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0149.Create_BetaUsage(options);
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