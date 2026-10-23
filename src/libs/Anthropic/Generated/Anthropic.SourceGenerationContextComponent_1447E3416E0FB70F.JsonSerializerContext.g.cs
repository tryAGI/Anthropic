
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1447E3416E0FB70F
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_70A5E6A12E2BCE81.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C7A0687852ACC8AF.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0282.Create_SourceGenerationContextMetadataType_1447E3416E0FB70F(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.List<global::Anthropic.BetaInputContentBlock>>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0305.Create_SourceGenerationContextMetadataType_A4AB08D2B9CFEB0A(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0309.Create_SourceGenerationContextMetadataType_C1AE9FF1FF7B4A55(options);
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