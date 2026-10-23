
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D22C9AFBF78EB66F
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_16AFBED54B7F6B0D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1A251F26BBF6920E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_30C8753F2B02005C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_433B424C139F3325.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_50C12D84EB1FF02A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6100303E1A57E607.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6DE6FCE06EB56432.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8CE2869496604065.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_91275F6EAD638F9C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_980FC82A1540E4E3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A47579D61DB87C74.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A96FEF9CBA37E6B6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B97D65D28E8D7A12.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DC69D4000D1EE17A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E72D6233BF087AF1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F7BEFF75C9A447D7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F87D1EBAA9CB22DF.MetadataScope,
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
                if (type == typeof(global::Anthropic.BetaComputerToolsetConfigs))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0023.Create_BetaComputerToolsetConfigs(options);
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