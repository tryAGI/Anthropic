
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9C2AE42C5A05E3E6
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_079A93EA66EDDAEF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_08B5B889C580A463.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_11A278CA88E95612.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_13B9A39D16175047.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_19C7D446E2E7E5E3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1EE516FDF60BBF27.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_26C1C5737F19144F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3125B2CE8D610BE6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_35F79CF74C6F03B8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4E88EEB7E93E7602.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4F277C3870766DF6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5D296801CC64F761.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5DE7A63FC22E30FC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_92C30ACC9E831F9D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9E53DE20A5252295.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A75A5B3A64542543.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AF53DF1238B165C9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C648F58B439970A2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CBBB297C280C52C8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D62D25AED283CD37.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D653B579A7A86F8E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FCAB06D26E247396.MetadataScope,
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
                if (type == typeof(global::System.Collections.Generic.IList<global::Anthropic.OneOf<global::Anthropic.Tool5, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.CodeExecutionTool20260521, global::Anthropic.BrowserToolset20260801, global::Anthropic.MemoryTool20250818, global::Anthropic.ComputerToolset20260801, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.WebSearchTool20260318, global::Anthropic.WebFetchTool20260318, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0286.Create_SourceGenerationContextMetadataType_9C2AE42C5A05E3E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::Anthropic.OneOf<global::Anthropic.Tool5, global::Anthropic.BashTool20250124, global::Anthropic.CodeExecutionTool20250522, global::Anthropic.CodeExecutionTool20250825, global::Anthropic.CodeExecutionTool20260120, global::Anthropic.CodeExecutionTool20260521, global::Anthropic.BrowserToolset20260801, global::Anthropic.MemoryTool20250818, global::Anthropic.ComputerToolset20260801, global::Anthropic.TextEditor20250124, global::Anthropic.TextEditor20250429, global::Anthropic.TextEditor20250728, global::Anthropic.WebSearchTool20250305, global::Anthropic.WebFetchTool20250910, global::Anthropic.WebSearchTool20260209, global::Anthropic.WebFetchTool20260209, global::Anthropic.WebFetchTool20260309, global::Anthropic.WebSearchTool20260318, global::Anthropic.WebFetchTool20260318, global::Anthropic.ToolSearchToolBM2520251119, global::Anthropic.ToolSearchToolRegex20251119>>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0287.Create_SourceGenerationContextMetadataType_A1C2AA31656FA5EB(options);
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