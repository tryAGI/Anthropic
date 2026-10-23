
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_91F9D945BA414F22
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_19A6C088B4DB8FB3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_3AA2F38713144F97.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_45796200624A0E09.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_49C2D6C89D1C8D9F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_79A5F54982E107E6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7D0FEF5783D679A2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CC905A03202B7A5E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CEFDB79C18521E9C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FB5F4564609D9E8B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,
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
                if (type == typeof(global::Anthropic.BetaManagedAgentsSession))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0084.Create_BetaManagedAgentsSession(options);
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