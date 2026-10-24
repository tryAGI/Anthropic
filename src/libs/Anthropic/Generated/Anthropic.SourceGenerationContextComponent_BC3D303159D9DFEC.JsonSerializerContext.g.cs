
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BC3D303159D9DFEC
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_19D949F16FAAA824.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1C12DC4A04B3003A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_631C36373985CE7C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6C3C39CCFC835A58.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_72FD87D89C7412F2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_799760E890D13799.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_86183A9BC6EF67CD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_955E93799F1558AF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E0ACD35CAAE7B035.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolConfigUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolConfigUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgentToolConfigUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0054.Create_BetaManagedAgentsAgentToolConfigUnion2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgentToolConfigUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0202.Create_NullableBetaManagedAgentsAgentToolConfigUnion2(options);
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