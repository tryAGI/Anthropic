
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8F7B68EC0C51B22A
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2856D93656B933DB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7C8B24CC75B1CA4A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B91E3D082716DBB1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BBE38925F3639B62.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolEvaluationJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolEvaluationJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgentToolEvaluation))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0055.Create_BetaManagedAgentsAgentToolEvaluation2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgentToolEvaluation?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0202.Create_NullableBetaManagedAgentsAgentToolEvaluation2(options);
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