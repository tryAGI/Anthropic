
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_496602ED577E9F89
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_05D7DBBD1612C245.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_33BAE0019616EB09.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4CE65E7E0BC2D069.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_592C01532529EFC8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5A527791ED4A4B52.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_659957D896C8ABF7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BA3A0C2C2375BD03.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BE82C615E0E85444.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CA121D58B7F44445.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F08119A300238B31.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Error2JsonConverter>(static () => new global::Anthropic.JsonConverters.Error2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Error2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0220.Create_Error22(options);
                }
                if (type == typeof(global::Anthropic.Error2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0280.Create_NullableError22(options);
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