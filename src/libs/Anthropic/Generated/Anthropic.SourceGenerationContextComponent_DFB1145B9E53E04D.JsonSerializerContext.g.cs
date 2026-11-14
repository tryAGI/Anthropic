
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_DFB1145B9E53E04D
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2C493362346473CE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_73C4D73DB3CB7D4E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A8644CA12ED98892.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B3B7525F2D00A94A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D18A609B6231EE0D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DA7012A32C07812A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DC596A069843913A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F466FC4255A7E830.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Scope7JsonConverter>(static () => new global::Anthropic.JsonConverters.Scope7JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Scope7))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0280.Create_Scope72(options);
                }
                if (type == typeof(global::Anthropic.Scope7?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0256.Create_NullableScope72(options);
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