
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_792EC638B22AC048
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_046003A56C94D003.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0D8FD6CFE79E4F6B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_278BC96E8387B0C1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_52A592E2AAF239FF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5533AD78B4C78B2E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5FB4966C5D8492E0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_632437CFB6F7CDEE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6694E62010F1B201.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_71AAB46756557774.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7D03F12D024B2EF8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A4C4BDA7ABFE0984.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C3C21D99F4333CE1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D320A04E95071929.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DB20CF65DEBBD39C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E0D14B9727B36617.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentPausedReasonErrorJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsDeploymentPausedReasonErrorJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0060.Create_BetaManagedAgentsDeploymentPausedReasonError2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsDeploymentPausedReasonError?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0213.Create_NullableBetaManagedAgentsDeploymentPausedReasonError2(options);
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