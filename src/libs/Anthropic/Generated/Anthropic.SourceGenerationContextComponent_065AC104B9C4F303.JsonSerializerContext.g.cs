
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_065AC104B9C4F303
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_033BB05B21C58F74.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_05EFFFA5175028DF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4400B77D512806FC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_486E1F1A4ADC7B4D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4E46C37A87D45E55.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5D14167537DF8C97.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5DE256DB4C9E9EEC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5FE8570D367E0D0C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_81324661729AAA25.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BF4FAB0B562C9536.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C5562052F422D3EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CAAA9E675D4C0B12.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CEF79F6E28537940.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D6BDDE94EF84FF37.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DC8923C7CDAE0914.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E0EBA0C8C6D16523.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F3C2D16EA5188FD1.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.InputContentBlockJsonConverter>(static () => new global::Anthropic.JsonConverters.InputContentBlockJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.InputContentBlock))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0180.Create_InputContentBlock2(options);
                }
                if (type == typeof(global::Anthropic.InputContentBlock?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0231.Create_NullableInputContentBlock2(options);
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