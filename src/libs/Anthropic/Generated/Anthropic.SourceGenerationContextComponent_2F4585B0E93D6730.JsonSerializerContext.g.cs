
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_2F4585B0E93D6730
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_12D36DF21E1E1335.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_30B635B53022E8F3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4A1AEA2B14AFD6A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_79A5F54982E107E6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8FBC75C1B230AC4B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A828A6FCDD6C024E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CA4C876713E71956.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CED1698C0ED40E37.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,
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
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgent))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0047.Create_BetaManagedAgentsAgent(options);
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