
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_20A8F07308578046
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_2085F2ACB5C517B6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_235A0C0EE864DE4C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_53CFC07BA270A142.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6C137367CF3905D7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_792B81EDE6AFD751.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7F817CA123475715.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E2110A78B9D19F76.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F73D421F39C968F6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsInputEventJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsInputEventJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsInputEvent))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0068.Create_BetaManagedAgentsInputEvent2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsInputEvent?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0217.Create_NullableBetaManagedAgentsInputEvent2(options);
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