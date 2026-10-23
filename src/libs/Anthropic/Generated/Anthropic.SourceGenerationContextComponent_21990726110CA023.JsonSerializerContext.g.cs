
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_21990726110CA023
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2468AE9C3108214D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_51DDF4444E1A389E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5500435699C33C89.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9C2AE42C5A05E3E6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9DB2021476CD81C1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A523ED17B54308F0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B3AA05947737406C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C739CB2D78BEDDB0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D3E64735616E561C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D6D64925BF115CC3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D8843B4512E03AC9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E55DFDADBBF5FE53.MetadataScope,
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
                if (type == typeof(global::Anthropic.CreateMessageParamsWithoutStream))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0180.Create_CreateMessageParamsWithoutStream(options);
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