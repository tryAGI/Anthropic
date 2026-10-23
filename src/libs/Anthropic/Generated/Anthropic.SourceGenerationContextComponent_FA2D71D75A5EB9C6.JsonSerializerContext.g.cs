
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FA2D71D75A5EB9C6
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_03167D54CC572D44.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_16FF5FACE375C921.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_339396B21769BCDB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_465C41ADA0EABF24.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_470D3E0784BBCBAF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_47D01B78FE490C6C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_47D398744B17B6B1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_47F4CE9D9E82C4E9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4A60FC8ABF66A7F4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4B9908BAAF423A7D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_563AD1616870F153.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7A38BFA64888360A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7BDC66F6EE9EA4A7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7CC8C2497CE79D72.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8524CC3E3114CEA3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_890AEB69AFCCB93D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_904F1DB4049B5355.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AB88ABB0F6517F93.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AD5E06726A25C8C7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B2932A6DA46F5D40.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C50F06C9912BA3EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C59167809689F656.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CAEEEA5FA3276EB6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E7CE4A6F272C24B4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EA811D847B1F21EA.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EAB232C5156AE9C6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F745FD9A283334A6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FD26650CB51F77E1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FF761CEC9E2DD3ED.MetadataScope,
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
                if (type == typeof(global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaCodeExecutionTool20260521, global::Anthropic.BetaBrowserToolset20260801, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaComputerToolset20260801, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaWebSearchTool20260318, global::Anthropic.BetaWebFetchTool20260318, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0320.Create_SourceGenerationContextMetadataType_FA2D71D75A5EB9C6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::Anthropic.OneOf<global::Anthropic.BetaTool, global::Anthropic.BetaBashTool20241022, global::Anthropic.BetaBashTool20250124, global::Anthropic.BetaCodeExecutionTool20250522, global::Anthropic.BetaCodeExecutionTool20250825, global::Anthropic.BetaCodeExecutionTool20260120, global::Anthropic.BetaCodeExecutionTool20260521, global::Anthropic.BetaBrowserToolset20260801, global::Anthropic.BetaComputerUseTool20241022, global::Anthropic.BetaMemoryTool20250818, global::Anthropic.BetaComputerUseTool20250124, global::Anthropic.BetaTextEditor20241022, global::Anthropic.BetaComputerUseTool20251124, global::Anthropic.BetaComputerToolset20260801, global::Anthropic.BetaTextEditor20250124, global::Anthropic.BetaTextEditor20250429, global::Anthropic.BetaTextEditor20250728, global::Anthropic.BetaWebSearchTool20250305, global::Anthropic.BetaWebFetchTool20250910, global::Anthropic.BetaWebSearchTool20260209, global::Anthropic.BetaWebFetchTool20260209, global::Anthropic.BetaWebFetchTool20260309, global::Anthropic.BetaWebSearchTool20260318, global::Anthropic.BetaWebFetchTool20260318, global::Anthropic.BetaAdvisorTool20260301, global::Anthropic.BetaToolSearchToolBM2520251119, global::Anthropic.BetaToolSearchToolRegex20251119, global::Anthropic.BetaMCPToolset>>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0293.Create_SourceGenerationContextMetadataType_5D8BDA4DC2989E8F(options);
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